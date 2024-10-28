using DataAccess.DatabaseAccess.Deleters;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;
using Quartz;
using Serilog;

namespace PP_Capital.Jobs;

[DisallowConcurrentExecution]
public class HoldingsValidationJob(IDbContextFactory<PpcapitalContext> contextFactory, ILoader loader, IDeleter deleter, ILogger logger, ConfigSettings configSettings) : IJob
{
    public Task Execute(IJobExecutionContext jobContext)
    {
        using var context = contextFactory.CreateDbContext();
        var date = context.DexReturnDates.OrderByDescending(r => r.ReturnDate).First().ReturnDate;

        // Update holdings
        UpdateInstHoldings(date);
        UpdateCashHoldings(date);
        
        // // Create comparisons
        CreateInstrumentComparisons(date);
        CreateCashComparisons(date);

        StoreFundAllocations(date);
        // TODO: Remaining parts of step 7

        return Task.CompletedTask;
    }

    private void RollBankCashHoldings(DateTime date)
    {
        using var context = contextFactory.CreateDbContext();
        // These are the last holdings prior to the specified date
        var holdings = (
            from
                h in context.DexBankHoldingsCashes.Where(h => h.HoldingDate <= date)
            join
                maxH in (
                    from m in context.DexBankHoldingsCashes
                    where m.HoldingDate <= date
                    group m by
                        new
                        {
                            m.AccountId, m.Currency
                        }
                    into g
                    select new DexBankHoldingsCash()
                    {
                        AccountId = g.Key.AccountId,
                        Currency = g.Key.Currency,
                        HoldingDate = g.Max(h => h.HoldingDate),
                    })
                on
                new { h.AccountId, h.Currency, h.HoldingDate } equals new
                    { maxH.AccountId, maxH.Currency, maxH.HoldingDate }
            select
                h).ToList();
        
        // All the holdings that are not the specified date, need to rolled up to that date (assume a single day) 
        var notUpdatedHoldings = holdings
            .Where(h => h.HoldingDate < date)
            .Select(h =>
                new DexBankHoldingsCash()
                {
                    AccountId = h.AccountId,
                    Currency = h.Currency,
                    HoldingDate = date,
                    Amount = h.Amount,
                }
            ).ToList();
        
        // Insert the updated holdings
        loader.Load(notUpdatedHoldings);
    }
    private void RollBankInstrumentHoldings(DateTime date)
    {
        using var context = contextFactory.CreateDbContext();
        // These are the last holdings prior to the specified date
        var holdings = (
            from
                h in context.DexBankHoldingsInstruments.Where(h => h.HoldingDate <= date)
            join
                maxH in (
                    from m in context.DexBankHoldingsInstruments
                    where m.HoldingDate <= date
                    group m by
                        new
                        {
                            m.AccountId, m.Currency, m.InstrumentId
                        }
                    into g
                    select new DexBankHoldingsInstrument()
                    {
                        AccountId = g.Key.AccountId,
                        InstrumentId = g.Key.InstrumentId,
                        Currency = g.Key.Currency,
                        HoldingDate = g.Max(h => h.HoldingDate),
                    })
                on
                new { h.AccountId, h.Currency, h.InstrumentId, h.HoldingDate } equals new
                    { maxH.AccountId, maxH.Currency, maxH.InstrumentId, maxH.HoldingDate }
            select
                h).ToList();
        
        // All the holdings that are not the specified date, need to rolled up to that date (assume a single day) 
        var notUpdatedHoldings = holdings
            .Where(h => h.HoldingDate < date)
            .Select(h =>
                new DexBankHoldingsInstrument
                {
                    AccountId = h.AccountId,
                    Currency = h.Currency,
                    InstrumentId = h.InstrumentId,
                    HoldingDate = date,
                    Quantity = h.Quantity,
                }
            ).ToList();
        
        // Insert the updated holdings
        loader.Load(notUpdatedHoldings);
    }
    
    private void StoreFundAllocations(DateTime date)
    {
        using var context = contextFactory.CreateDbContext();
        var ppFundAccountIds = GetFundAccountIds();
        var lastReturnDate = context.DexReturnDates.Where(r => r.ReturnDate < date).OrderByDescending(r => r.ReturnDate).First().ReturnDate;
        var exchangeRates = context.DexExchangeRates.Where(e => e.ExRateDate == lastReturnDate);
        var instruments = context.DexInstruments;

        // Get cash holdings for each pp fund account
        // Keep only the client pp id, since that is what we are grouping by
        var ppCashDkk = (
                from cch in context.DexClientCashHoldings
                    .Where(c => c.HoldingDate == lastReturnDate && ppFundAccountIds.Select(a => a.AccountId).Contains(c.AccountId))
                join ca in context.DexClientAccounts on cch.AccountId equals ca.AccountId
                join cd in context.DexClientDepots on ca.DepotId equals cd.DepotId
                select new { cch.AmountAccCur, ca.Currency, cd.ClientPpId }
            )
            .ToList()
            .Select(c => (c.ClientPpId,
                c.AmountAccCur * exchangeRates.FirstOrDefault(e => e.Currency == c.Currency)?.ExRate))
            .GroupBy(x => x.ClientPpId)
            .Select(grouped =>
            {
                var clientPpId = grouped.FirstOrDefault().ClientPpId;
                var valueDkk = grouped.Sum(g => g.Item2);
                return (ClientPpId: clientPpId, valueDKK: valueDkk);
            })
            .ToList();

        var ppInstDkk = context.DexClientInstHoldings
            .Where(ih => ih.HoldingDate == lastReturnDate && ppFundAccountIds.Select(a => a.DepotId).Contains(ih.DepotId))
            .ToList()
            .Select(ih =>
            {
                var instrumentPrice = context.DexInstrumentPrices
                    .Where(i => i.PriceDate == lastReturnDate)
                    .First(p => p.InstrumentId == ih.InstrumentId).Price;
                var currency = instruments.First(i => i.InstrumentId == ih.InstrumentId).Currency;
                var valueDkk = ih.Quantity * instrumentPrice * exchangeRates.First(e => e.Currency == currency).ExRate;
                return (ppFundAccountIds.First(p => p.DepotId == ih.DepotId).ClientPpId, valueDKK: valueDkk, ih.InstrumentId);
            })
            .ToList();

        var fundInstDkk = ppInstDkk
            .GroupBy(x => x.ClientPpId)
            .Select(grouped =>
            {
                var ppId = grouped.FirstOrDefault().ClientPpId;
                var valueDkk = grouped.Sum(g => g.Item2);
                return (ppId, valueDKK: valueDkk);
            })
            .ToList();

        var instrumentWeights = ppInstDkk.Select(p =>
        {
            var weight = p.valueDKK / (fundInstDkk.FirstOrDefault(f => f.ppId == p.ClientPpId).valueDKK +
                                       (ppCashDkk.FirstOrDefault(f => f.ClientPpId == p.ClientPpId).valueDKK ?? 0));
            return (p.ClientPpId, p.InstrumentId, Weight : weight);
        }).ToList();

        // Step 2 merge with etf sector data
        var ppSectorHoldings = (
                from i in instrumentWeights
                join e in context.DexInstrumentSectorAllocs.Where(isa => isa.AllocDate == lastReturnDate)
                    on i.InstrumentId equals e.InstrumentId
                    into sectors
                from e in sectors.DefaultIfEmpty()
                select (
                    i.ClientPpId,
                    i.InstrumentId,
                    i.Weight,
                    e?.IndustrySectorName,
                    IndustrySectorAllocationPercentage: e?.IndustrySectorAllocationPercentage ?? 100,
                    AssetClass: "",
                    InstrumentSectorWeightAllocationPercentage: 0.0)
            )
            .Select(p =>
            {
                var instrument = instruments.First(i => i.InstrumentId == p.InstrumentId);

                if (instrument.BpipeReferenceSecurityClass == "Equity")
                {
                    p.AssetClass = "Equity";
                    p.IndustrySectorName = EquityToFundAllocation(instrument.ClassificationLevel1Name);
                    p.IndustrySectorAllocationPercentage = 100;
                }

                if (instrument.BpipeReferenceSecurityClass == "FixedIncome")
                {
                    p.AssetClass = FixedIncomeToFundAllocation(instrument.ClassificationLevel1Name);
                    if (p.AssetClass == "FI_UNKNOWN")
                    {
                        if (Level2FixedIncome(instrument.ClassificationLevel2Name) == null)
                        {
                            logger.Information(instrument.ClassificationLevel1Name ?? "");
                            logger.Error("Wrong classification level from BB");
                        }

                        p.AssetClass = Level2FixedIncome(instrument.ClassificationLevel2Name);
                    }
                }

                if (instrument.BpipeReferenceSecurityClass == "Fund")
                {
                    p.AssetClass = FundToAssetClassFocus(instrument.FundAssetClassFocus);
                }

                // Notice its asset class and not the instrument Bpipe
                if (p.AssetClass == "Bonds")
                {
                    p.AssetClass = FundStrategyToClass(instrument.FundStrategy);
                }

                p.InstrumentSectorWeightAllocationPercentage =
                    (double)(p.IndustrySectorAllocationPercentage * p.Weight);
                return p;
            })
            .ToList();
        
        // Country
        var ppCountryAllocs = (
                from i in instrumentWeights
                join e in context.DexInstrumentCntryAllocs.Where(a => a.AllocDate == lastReturnDate)
                    on i.InstrumentId equals e.InstrumentId
                    into countries
                from e in countries.DefaultIfEmpty()
                select (
                    i.ClientPpId,
                    i.InstrumentId,
                    i.Weight,
                    GeographicalRegion: e?.GeographicalRegion ??
                                        CountryISO(instruments.First(inst => inst.InstrumentId == i.InstrumentId)
                                            .CountryIso),
                    CountryAllocationPercentage: e?.PercentOfFund ?? 100,
                    CountryWeightAllocation: i.Weight * (e?.PercentOfFund ?? 100)
                )
            )
            .GroupBy(x => (x.ClientPpId, x.GeographicalRegion))
            .Select(group =>
            {
                return new DexInstrumentCntryAlloc()
                {
                    AllocDate = date,
                    GeographicalRegion = group.First().GeographicalRegion,
                    BbTicker = FundIdToTicker(group.First().ClientPpId),
                    InstrumentId = FundClientToInstrumentId(group.First().ClientPpId),
                    PercentOfFund = (group.Sum(g => g.CountryWeightAllocation))
                };
            })
            .ToList();

        var ppFundSectorAllocation = ppSectorHoldings.GroupBy(x => (x.ClientPpId, x.IndustrySectorName)).Select(group =>
            {
                return new DexInstrumentSectorAlloc
                {
                    AllocDate = date,
                    IndustrySectorName = group.First().IndustrySectorName,
                    BbTicker = FundIdToTicker(group.First().ClientPpId),
                    InstrumentId = FundClientToInstrumentId(group.First().ClientPpId),
                    IndustrySectorAllocationPercentage = group.Sum(g => g.InstrumentSectorWeightAllocationPercentage)
                };
            })
            .ToList();

        var ppAssetClass = ppSectorHoldings
            .GroupBy(x => (x.ClientPpId, x.AssetClass))
            .Select(group =>
            {
                return new DexPpFundAssetClassAlloc
                {
                    AllocDate = date,
                    BbTicker = FundIdToTicker(group.First().ClientPpId),
                    InstrumentId = FundClientToInstrumentId(group.First().ClientPpId),
                    AssetClass = group.First().AssetClass,
                    AssetClassPct = group.First().AssetClass == "Alternativer" ?
                        group.Sum(g => g.Weight * 100):
                        group.Sum(g => g.InstrumentSectorWeightAllocationPercentage)
                };
            });

        var cashHolding = ppCashDkk.Select(p =>
            {
                var weight = p.valueDKK / (fundInstDkk.First(f => f.ppId == p.ClientPpId).valueDKK + p.valueDKK) * 100;
                return (p.ClientPpId, weight);
            })
            .ToList()
            .Select(c =>
            {
                return new DexPpFundAssetClassAlloc
                {
                    AllocDate = date,
                    BbTicker = FundIdToTicker(c.ClientPpId),
                    InstrumentId = FundClientToInstrumentId(c.ClientPpId),
                    AssetClass = "Kontant",
                    AssetClassPct = (100.0 - ppAssetClass.Where(p => p.BbTicker == FundIdToTicker(c.ClientPpId))
                        .Sum(p => p.AssetClassPct))
                };
            });
        
        var allAssetAllocations = ppAssetClass.Concat(cashHolding).ToList();
        
        loader.Load(ppCountryAllocs);
        loader.Load(ppFundSectorAllocation);
        loader.Load(allAssetAllocations);
    }

    private void UpdateCashHoldings(DateTime date)
    {
        using var context = contextFactory.CreateDbContext();

        var valueTrans = new TransactionsHelper(context).GetTransactionsOnDate(date);
        var groupedCashImpact = valueTrans
            .Where(x => x.CashImpact == 1)
            .GroupBy(x => x.AccountId)
            .Select(grouped =>
            {
                var accountId = grouped.Select(x => x.AccountId).First();
                var value = grouped.Sum(x => x.Amount);
                return (accountId, value);
            }).ToList();
        
        var lastReturnDate = context.DexReturnDates.Where(r => r.ReturnDate < date).OrderByDescending(r => r.ReturnDate).First().ReturnDate;
        var updatedCashHoldings = context.DexClientCashHoldings
            .Where(x => x.HoldingDate == lastReturnDate)
            .ToList()
            .Select(c =>
                {
                    return new DexClientCashHolding
                    {
                        InputDate = DateTime.Today,
                        HoldingDate = date,
                        AmountAccCur = c.AmountAccCur +
                                       groupedCashImpact.FirstOrDefault(x => x.accountId == c.AccountId).value,
                        AccountId = c.AccountId,
                    };
                }
            )
            .Where(c => !GetFundAccountIds().Select(f => f.AccountId).Contains(c.AccountId))
            .ToList();
        
        // Bulk delete holdings for non-PP fund holdings on the date and write new ones
        // PP fund holdings are updated via API call to fund-market, so we need to keep them the same
        // This is why they are filtered out above
        var ppAccountIds = GetFundAccountIds().Select(f => f.AccountId).ToList();
        deleter.DeleteClientCashHoldingsForDate(date, ppAccountIds);
        loader.BulkLoad(updatedCashHoldings);
    }

    private void CreateCashComparisons(DateTime date)
    {
        using var context = contextFactory.CreateDbContext();
        
        // Get previous days holdings in PP system
        var clientCash = context.DexClientCashHoldings.Where(c => c.HoldingDate == date)
            .GroupBy(c => c.AccountId)
            .ToList()
            .Select(g =>
            {
                var total = g.Sum(x => x.AmountAccCur);
            return (g.First().AccountId, total);
        }).ToList();
        
        // Get current days holdings in bank
        var bankCashHoldings = contextFactory.CreateDbContext().DexBankHoldingsCashes.Where(x => x.HoldingDate == date).ToList();

        var valueTrans = new TransactionsHelper(context).GetTransactionsWithLaterValueDate(date);
        var groupedCashImpact = valueTrans
            .Where(x => x.CashImpact == 1)
            .GroupBy(x => x.AccountId)
            .Select(grouped =>
            {
                var accountId = grouped.Select(x => x.AccountId).First();
                var value = grouped.Sum(x => x.Amount);
                return (accountId, value);
            }).ToList();

        // Compare the pp holding adjusted cash impact transactions with bank holdings
        var cashComparison = (
            from c in clientCash
            join a in bankCashHoldings
                on c.AccountId equals a.AccountId
            select new DexComparisonsCash
            {
                InputDate = DateTime.Today,
                HoldingDate = date,
                AccountId = a.AccountId,
                PpAmount = (decimal)c.total,
                BankAmount = a.Amount,
                Currency = a.Currency,
                Value = (decimal)groupedCashImpact.FirstOrDefault(x => x.accountId == c.AccountId).value,
                Diff = (decimal)c.total - a.Amount - (decimal)groupedCashImpact.FirstOrDefault(x => x.accountId == c.AccountId).value,
                Resolved = 0,
            }
        ).Where(cc => Math.Abs(cc.Diff ?? 0) > configSettings.Thresholds.CashValidationThreshold).ToList();


        // Bulk delete and load comparisons
        deleter.DeleteCashComparisonsForDate(date);
        loader.BulkLoad(cashComparison);
    }
    
    private void CreateInstrumentComparisons(DateTime date)
    {
        // Instrument comparisons happen on depot basis
        // Everything is therefore grouped by depot and instrument
        using var context = contextFactory.CreateDbContext();
        var accounts = context.DexClientAccounts;
        
        // Find quantity from bank file holdings
        var bankInstHolding = context.DexBankHoldingsInstruments.ToList()
            .Where(x => x.HoldingDate == date)
            .GroupBy(x => (GetDepotId(accounts, x.AccountId), x.InstrumentId))
            .Select(group =>
            {
                var depotId = group.Select(x => GetDepotId(accounts, x.AccountId)).First();
                var instrumentId = group.Select(x => x.InstrumentId).First();
                var quantity = group.Sum(x => x.Quantity);
                return (depotId, instrumentId, quantity);
            })
            .ToList();

        var valueTransactions = new TransactionsHelper(context).GetSecurityTransactionsWithLaterValueDate(date);
        var groupedNominalImpact = valueTransactions
            .Where(x => x.NominalImpact == 1 && x.PpTransaction == 1)
            .GroupBy(x => (GetDepotId(accounts, x.AccountId), x.InstrumentId))
            .Select(grouped =>
            {
                var accountId = grouped.Select(x => x.AccountId).First();
                var depotId = GetDepotId(accounts, accountId);
                var instrumentId = grouped.Select(x => x.InstrumentId).First();
                var value = grouped.Sum(x => x.Quantity);
                return (depotId, instrumentId, value);
            }).ToList();

        // Make comparisons
        var instrumentComparison = (
            from cid in context.DexClientInstHoldings.Where(c => c.HoldingDate == date).ToList()
            join bid in bankInstHolding
                on new
                {
                    A = cid.DepotId, B = cid.InstrumentId
                } equals new
                {
                    A = bid.depotId, B = bid.instrumentId
                }
            select new DexComparisonsInstrument()
            {
                InputDate = DateTime.Today,
                HoldingDate = date,
                DepotId = cid.DepotId,
                InstrumentId = cid.InstrumentId,
                PpQuantity = (decimal)cid.Quantity,
                BankQuantity = bid.quantity,
                Value = (decimal)groupedNominalImpact.FirstOrDefault(x => x.depotId == cid.DepotId && x.instrumentId == cid.InstrumentId).value,
                Diff = (decimal)cid.Quantity - bid.quantity - (decimal)groupedNominalImpact
                        .FirstOrDefault(x => x.depotId == cid.DepotId && x.instrumentId == cid.InstrumentId).value,
                Resolved = 0,
            }
        ).Where(cc => Math.Abs(cc.Diff ?? 0) > configSettings.Thresholds.InstrumentValidationThreshold).ToList();

        // Bulk delete and load comparisons
        deleter.DeleteInstrumentComparisonsForDate(date);
        loader.BulkLoad(instrumentComparison);
    }

    private void UpdateInstHoldings(DateTime date)
    {
        // Only update holdings on valid return dates
        using var context = contextFactory.CreateDbContext();
        
        var accounts = context.DexClientAccounts;
        var valueTrans = new TransactionsHelper(context).GetSecurityTransactionsTradedOnDate(date);
        var lastReturnDate = context.DexReturnDates.Where(r => r.ReturnDate < date).OrderByDescending(r => r.ReturnDate).First().ReturnDate;

        // Find effect of trades for the day
        var groupedNominalImpact = valueTrans
            .Where(x => x.NominalImpact == 1 && x.PpTransaction == 1)
            .GroupBy(x => (GetDepotId(accounts, x.AccountId), x.InstrumentId))
            .Select(grouped =>
            {
                var accountId = grouped.Select(x => x.AccountId).First();
                var depotId = GetDepotId(accounts, accountId);
                var instrumentId = grouped.Select(x => x.InstrumentId).First();
                var value = grouped.Sum(x => x.Quantity);
                return (depotId, instrumentId, value);
            }).ToList();
        
        // Update holdings
        var updatedInstHoldings = context.DexClientInstHoldings
            .Where(x => x.HoldingDate == lastReturnDate)
            .ToList()
            .Select(c =>
            {
                return new DexClientInstHolding
                {
                    InputDate = DateTime.Today,
                    DepotId = c.DepotId,
                    InstrumentId = c.InstrumentId,
                    HoldingDate = date,
                    Quantity = c.Quantity + groupedNominalImpact
                        .FirstOrDefault(x => x.depotId == c.DepotId && x.instrumentId == c.InstrumentId).value
                };
            })
            .ToList();
        
        // Bulk delete holdings for the date and write new ones
        deleter.DeleteClientInstrumentHoldingsForDate(date, []);
        loader.BulkLoad(updatedInstHoldings);
    }

    private int GetDepotId(DbSet<DexClientAccount> accounts, int accountId)
    {
        return accounts.Where(acc => acc.AccountId == accountId).Select(acc => acc.DepotId).FirstOrDefault();
    }

    private List<ClientAccountOverview> GetFundAccountIds()
    {
        var ppIds = new List<int>{9991, 9997, 9998, 9999};
        var ppFundAccountIds = contextFactory.CreateDbContext().ClientAccountOverviews
            .Where(c => ppIds.Contains(c.ClientPpId ?? 0))
            .ToList();
        
        return ppFundAccountIds;
    }
    private string FixedIncomeToFundAllocation(string? fixedIncome){
        return fixedIncome switch
        {
            "Treasury" => "Statsobligationer",
            "Government-Related" => "Statsobligationer",
            "Corporate" => "Kreditobligationer",
            "Securitized" => "FI_UNKNOWN",
            "Municipal" => "Statsobligationer",
            _ => throw new Exception($"Unknown fixed income: {fixedIncome}")
        };
    }
    private string EquityToFundAllocation(string? equity)
    {
        return equity switch
        {
            "Technology" => "Technology",
            "Industrials" => "Industrial",
            "Consumer Discretionary" => "Consumer, Cyclical",
            "Health Care" => "Consumer, Non-cyclical",
            "Real Estate" => "Financial",
            "Consumer Staples" => "Consumer, Non-cyclical",
            "Financials" => "Financial",
            "Energy" => "Energy",
            "Communications" => "Communications",
            "Materials" => "Basic Materials",
            "Utilities" => "Utilities",
            _ => throw new Exception($"Unknown equity: {equity}")
        };
    }

    private string? Level2FixedIncome(string? fixedIncome)
    {
        return fixedIncome switch
        {
            "Covered" => "Realkreditobligationer",
            "Securitized" => "Realkreditobligationer",
            "MBS Pass-Through" => "Alternativer",
            "ABS" => "Alternativer",
            "CMBS" => "Alternativer",
            "CMO" => "Alternativer",
            "CLO" => "Alternativer",
            "CDO" => "Alternativer",
            _ => null
        };
    }

    private string? FundToAssetClassFocus(string? fund)
    {
        return fund switch
        {
            "Alternative" => "Alternativer",
            "Commodity" => "Alternativer",
            "Equity" => "Equity",
            "Fixed Income" => "Bonds",
            "Mixed Allocation" => "Mixed Allocation",
            "Money Market" => "Statsobligationer",
            _ => null
        };
    }
    
    private string? FundStrategyToClass(string? fund)
    {
        return fund switch
        {  
            "Corporate" => "Kreditobligationer",
            "Government" => "Statsobligationer",
            "Aggregate" => "Statsobligationer",
            "Convertible" => "Kreditobligationer",
            "Inflation Protected" => "Statsobligationer",
            "Bank Loans" => "Kreditobligationer",
            "Fixed Income Directional" => "Kreditobligationer",
            "Global Allocation" => "Statsobligationer",
            "Mortgage" => "Realkreditobligationer",
            _ => null
        };
    }

    private string? CountryISO(string countryIsoCode)
    {
        return countryIsoCode switch
        {
            "AE" => "U.A.E.",
            "AT" => "Austria",
            "AU" => "Australia",
            "BE" => "Belgium",
            "CA" => "Canada",
            "CH" => "Switzerland",
            "CN" => "China",
            "DE" => "Germany",
            "DK" => "Denmark",
            "EE" => "Estonia",
            "ES" => "Spain",
            "FI" => "Finland",
            "FO" => "Faroe Islands",
            "FR" => "France",
            "GB" => "U.K.",
            "GL" => "Greenland",
            "HK" => "Hong Kong",
            "IE" => "Ireland",
            "IL" => "Israel",
            "IN" => "India",
            "IS" => "Iceland",
            "IT" => "Italy",
            "JE" => "Jersey",
            "KR" => "South Korea",
            "KY" => "Cayman Islands",
            "LU" => "Luxembourg",
            "MC" => "Monaco",
            "MH" => "Marshall Islands",
            "MT" => "Malta",
            "MULT" => "Index",
            "NL" => "Netherlands",
            "NO" => "Norway",
            "RU" => "Romania",
            "SE" => "Sweden",
            "SG" => "Singapore",
            "SNAT" => "Supranational",
            "US" => "U.S.",
            "ZA" => "South Africa",
            _ => throw new Exception($"Unknown country: {countryIsoCode}")
        };
    }

    private string FundIdToTicker(int? fundId)
    {
        return fundId switch
        {
            9991 => "/Isin/DK0062270666",
            9997 => "PMICTAAK DC Equity",
            9998 => "PPBAKLEU DC Equity",
            9999 => "PMIPCSPK DC Equity",
        };
    }
    
    private int FundClientToInstrumentId(int? fundClient)
    {
        return fundClient switch
        {
            9991 => 2215,
            9997 => 1055,
            9998 => 1058,
            9999 => 1056,
        };
    }
}