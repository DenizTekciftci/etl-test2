using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Infrastructure;
using DataAccess.DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Loaders;

public interface ILoader
{
    public void Load(List<DexCost> dexCosts);
    public void Load(List<DexBankHoldingsCash> cashHoldings);
    public void Load(List<DexBankHoldingsInstrument> instrumentHoldings);
    public void Load(List<(DexCashTransaction, List<DexCost>)> transformed);
    public void Load(List<(DexDividendTransaction, List<DexCost>)> transformed);
    public void Load(List<(DexSecurityTransaction, List<DexCost>)> transformed);
    public void Load(DexStagingSecurityTransaction transaction, List<DexStagingCost> costs);
    public void Load(DexStagingDividendTransaction transaction, List<DexStagingCost> costs);
    public void Load(DexStagingCashTransaction transaction, List<DexStagingCost> costs);
    public void Load(DexStagingBondCoupon transaction, List<DexStagingCost> costs);
    public void Load(List<DexFundCode> fundCodes);
    public void Load(List<(DexBondCoupon, List<DexCost>)> transformed);
    public void Load(List<DexInstrumentCntryAlloc> countryAllocs);
    public void Load(List<DexInstrumentSectorAlloc> sectorAllocs);
    public void Load(List<DexPpFundAssetClassAlloc> sectorAllocs);
    public void BulkLoad(List<DexComparisonsCash> cashComparisons);
    public void BulkLoad(List<DexComparisonsInstrument> instrumentComparisons);
    public void BulkLoad(List<DexClientCashHolding> cashHoldings);
    public void BulkLoad(List<DexClientInstHolding> instHoldings);
}

public class Loader(IDbContextFactory<PpcapitalContext> contextFactory, IInstrumentHelper instrumentHelper) : ILoader
{
    public void Load(List<DexCost> dexCosts)
    {
        foreach (var cost in dexCosts)
        {
            try
            {
                using var context = contextFactory.CreateDbContext();
                LoadCost(context, cost);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    
    public void Load(List<DexBankHoldingsCash> cashHoldings)
    {
        foreach (var cashHolding in cashHoldings)
        {
            try
            {
                using var context = contextFactory.CreateDbContext();;
                LoadBankCashHolding(context, cashHolding);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    
    public void Load(List<DexBankHoldingsInstrument> instrumentHoldings)
    {
        foreach (var instrumentHolding in instrumentHoldings)
        {
            try
            {
                using var context = contextFactory.CreateDbContext();;
                LoadInstrumentHolding(context, instrumentHolding);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    
    public void Load(List<(DexCashTransaction, List<DexCost>)> transformed)
    {
        foreach (var (transaction, costs) in transformed)
        {
            try
            {
                using var context = contextFactory.CreateDbContext();
                LoadCashTransaction(context, transaction);
                foreach (var cost in costs)
                {
                    cost.TransactionId = transaction.TransactionId;
                    LoadCost(context, cost);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    
    public void Load(List<(DexDividendTransaction, List<DexCost>)> transformed)
    {
        foreach (var (transaction, costs) in transformed)
        {
            try
            {
                using var context = contextFactory.CreateDbContext();
                LoadDividendTransaction(context, transaction);
                foreach (var cost in costs)
                {
                    cost.TransactionId = transaction.TransactionId;
                    LoadCost(context, cost);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    
    public void Load(List<(DexSecurityTransaction, List<DexCost>)> transformed)
    {
        foreach (var (transaction, costs) in transformed)
        {
            try
            {
                using var context = contextFactory.CreateDbContext();
                LoadSecurityTransaction(context, transaction);
                foreach (var cost in costs)
                {
                    cost.TransactionId = transaction.TransactionId;
                    LoadCost(context, cost);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public void Load(DexStagingSecurityTransaction transaction, List<DexStagingCost> costs)
    {
        try
        {
            using var context = contextFactory.CreateDbContext();
            LoadStagingSecurityTransaction(context, transaction);
            foreach (var cost in costs)
            {
                cost.StagingTransactionId = transaction.StagingTransactionId;
                LoadStagingCost(context, cost);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Load(DexStagingDividendTransaction transaction, List<DexStagingCost> costs)
    {
        try
        {
            using var context = contextFactory.CreateDbContext();
            LoadStagingDividendTransaction(context, transaction);
            foreach (var cost in costs)
            {
                cost.StagingTransactionId = transaction.StagingTransactionId;
                LoadStagingCost(context, cost);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Load(DexStagingCashTransaction transaction, List<DexStagingCost> costs)
    {
        try
        {
            using var context = contextFactory.CreateDbContext();
            LoadStagingCashTransaction(context, transaction);
            foreach (var cost in costs)
            {
                cost.StagingTransactionId = transaction.StagingTransactionId;
                LoadStagingCost(context, cost);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Load(DexStagingBondCoupon transaction, List<DexStagingCost> costs)
    {
        try
        {
            using var context = contextFactory.CreateDbContext();
            LoadStagingBondCoupon(context, transaction);
            foreach (var cost in costs)
            {
                cost.StagingTransactionId = transaction.StagingTransactionId;
                LoadStagingCost(context, cost);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Load(List<(DexBondCoupon, List<DexCost>)> transformed)
    {
        foreach (var (transaction, costs) in transformed)
        {
            try
            {
                using var context = contextFactory.CreateDbContext();
                LoadBondCoupon(context, transaction);
                foreach (var cost in costs)
                {
                    cost.TransactionId = transaction.TransactionId;
                    LoadCost(context, cost);
                }
            }
            catch (Exception e)
            {
                 Console.WriteLine(e.Message);
            }
        }
    }

    public void BulkLoad(List<DexComparisonsCash> cashComparisons)
    {
        using var context = contextFactory.CreateDbContext();
        context.DexComparisonsCashes.AddRange(cashComparisons);
        context.SaveChanges();
    }

    public void BulkLoad(List<DexComparisonsInstrument> instrumentComparisons)
    {
        using var context = contextFactory.CreateDbContext();
        context.DexComparisonsInstruments.AddRange(instrumentComparisons);
        context.SaveChanges();
    }

    public void BulkLoad(List<DexClientCashHolding> cashHoldings)
    {
        using var context = contextFactory.CreateDbContext();
        context.DexClientCashHoldings.AddRange(cashHoldings);
        context.SaveChanges();
    }
    
    public void BulkLoad(List<DexClientInstHolding> instHoldings)
    {
        try
        {
            using var context = contextFactory.CreateDbContext();
            context.DexClientInstHoldings.AddRange(instHoldings);
            context.SaveChanges();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Load(List<DexInstrumentCntryAlloc> countryAllocs)
    {
        foreach (var countryAlloc in countryAllocs)
        {
            try
            {
                using var context = contextFactory.CreateDbContext();
                LoadCountryAlloc(context, countryAlloc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public void Load(List<DexInstrumentSectorAlloc> sectorAllocs)
    {
        foreach (var sectorAlloc in sectorAllocs)
        {
            try
            {
                using var context = contextFactory.CreateDbContext();
                LoadSectorAlloc(context, sectorAlloc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public void Load(List<DexPpFundAssetClassAlloc> assetClassAllocs)
    {
        foreach (var assetClassAlloc in assetClassAllocs)
        {
            try
            {
                using var context = contextFactory.CreateDbContext();
                LoadAssetClassAlloc(context, assetClassAlloc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public void Load(List<DexFundCode> fundCodes)
    {
        foreach (var fundCode in fundCodes)
        {
            try
            {
                using var context = contextFactory.CreateDbContext();
                fundCode.InstrumentId = instrumentHelper.GetInstrumentIdByIsin(fundCode.Isin ?? "");
                LoadFundCode(context, fundCode);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    private static void LoadInstrumentHolding(PpcapitalContext context, DexBankHoldingsInstrument instrumentHolding)
    {
        var entry = context.DexBankHoldingsInstruments.DeleteIfExistsAndInsert(instrumentHolding, c =>
            c.HoldingDate == instrumentHolding.HoldingDate &&
            c.AccountId == instrumentHolding.AccountId &&
            c.Currency == instrumentHolding.Currency &&
            c.InstrumentId == instrumentHolding.InstrumentId);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexCashTransaction)));
        }

        context.SaveChanges();
    }
    
    private static void LoadBankCashHolding(PpcapitalContext context, DexBankHoldingsCash holdingsCash)
    {
        var entry = context.DexBankHoldingsCashes.DeleteIfExistsAndInsert(holdingsCash, c =>
            c.HoldingDate == holdingsCash.HoldingDate &&
            c.AccountId == holdingsCash.AccountId &&
            c.Currency == holdingsCash.Currency);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexBankHoldingsCash)));
        }

        context.SaveChanges();
    }

    private static void LoadCost(PpcapitalContext context, DexCost cost)
    {
        var entry = context.DexCosts.AddIfNotExists(cost, c =>
            c.TradeDate == cost.TradeDate &&
            c.ValueDate == cost.ValueDate &&
            c.TradeTypeId == cost.TradeTypeId &&
            c.AccountId == cost.AccountId &&
            c.Currency == cost.Currency &&
            c.BankCostId == cost.BankCostId &&
            Math.Abs(c.Amount - cost.Amount) < 0.01);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexCost)));
        }

        context.SaveChanges();
    }
    
    private static void LoadStagingCost(PpcapitalContext context, DexStagingCost cost)
    {
        var entry = context.DexStagingCosts.AddIfNotExists(cost, c =>
            c.TradeDate == cost.TradeDate &&
            c.ValueDate == cost.ValueDate &&
            c.TradeTypeId == cost.TradeTypeId &&
            c.Account == cost.Account &&
            c.Account == cost.Account &&
            c.Currency == cost.Currency &&
            c.BankCostId == cost.BankCostId &&
            Math.Abs(c.Amount - cost.Amount) < 0.01);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexStagingCost)));
        }

        context.SaveChanges();
    }

    private static void LoadCashTransaction(PpcapitalContext context, DexCashTransaction cash)
    {
        // Do not match on trade type id, because transactions could have been labeled FX
        var entry = context.DexCashTransactions.AddIfNotExists(cash, cashTransaction =>
            cashTransaction.TradeDate == cash.TradeDate &&
            cashTransaction.ValueDate == cash.ValueDate &&
            cashTransaction.AccountId == cash.AccountId &&
            cashTransaction.CashImpact == cash.CashImpact &&
            cashTransaction.Currency == cash.Currency &&
            Math.Abs(cashTransaction.Amount - cash.Amount) < 0.01);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexCashTransaction)));
        }

        context.SaveChanges();
    }
    
    private static void LoadCashComparison(PpcapitalContext context, DexComparisonsCash cashComparison)
    {
        var existingEntity = context.DexComparisonsCashes.FirstOrDefault(c =>
            c.AccountId == cashComparison.AccountId &&
            c.Currency == cashComparison.Currency &&
            c.HoldingDate == cashComparison.HoldingDate);

        if (existingEntity != null)
        {
            // Update the new entry
            // If the diff is unchanged, keep the resolved status as is
            //if (Math.Abs(existingEntity.Diff - cashComparison.Diff) < 0.02m)
            cashComparison.Resolved = existingEntity.Resolved;
            
            context.DexComparisonsCashes.Remove(existingEntity);
        }
        
        context.Add(cashComparison);
        context.SaveChanges();
    }
    
    private static void LoadInstrumentComparison(PpcapitalContext context, DexComparisonsInstrument instrumentComparison)
    {
        var existingEntity = context.DexComparisonsInstruments.FirstOrDefault(c =>
            c.DepotId == instrumentComparison.DepotId &&
            c.InstrumentId == instrumentComparison.InstrumentId &&
            c.HoldingDate == instrumentComparison.HoldingDate);
        
        if (existingEntity != null)
        {
            // Update the new entry
            // If the diff is unchanged, keep the resolved status as is
            if (Math.Abs((existingEntity.Diff - instrumentComparison.Diff) ?? 0) < 0.02m)
                instrumentComparison.Resolved = existingEntity.Resolved;
            
            context.DexComparisonsInstruments.Remove(existingEntity);
        }

        context.Add(instrumentComparison);
        context.SaveChanges();
    }
    
    private static void LoadCashHolding(PpcapitalContext context, DexClientCashHolding cashHolding)
    {
        var entry = context.DexClientCashHoldings.DeleteIfExistsAndInsert(cashHolding, c =>
            c.AccountId == cashHolding.AccountId &&
            c.HoldingDate == cashHolding.HoldingDate);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexClientCashHolding)));
        }

        context.SaveChanges();
    }
    
    private static void LoadInstHolding(PpcapitalContext context, DexClientInstHolding instHolding)
    {
        var entry = context.DexClientInstHoldings.DeleteIfExistsAndInsert(instHolding, c =>
            c.DepotId == instHolding.DepotId &&
            c.InstrumentId == instHolding.InstrumentId &&
            c.HoldingDate == instHolding.HoldingDate);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexClientInstHolding)));
        }

        context.SaveChanges();
    }
    
    private static void LoadCountryAlloc(PpcapitalContext context, DexInstrumentCntryAlloc countryAlloc)
    {
        var entry = context.DexInstrumentCntryAllocs.DeleteIfExistsAndInsert(countryAlloc, c =>
            c.GeographicalRegion == countryAlloc.GeographicalRegion &&
            c.InstrumentId == countryAlloc.InstrumentId &&
            c.BbTicker == countryAlloc.BbTicker &&
            c.AllocDate == countryAlloc.AllocDate);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexInstrumentCntryAlloc)));
        }

        context.SaveChanges();
    }
    
    private static void LoadSectorAlloc(PpcapitalContext context, DexInstrumentSectorAlloc sectorAlloc)
    {
        var entry = context.DexInstrumentSectorAllocs.DeleteIfExistsAndInsert(sectorAlloc, c =>
            c.IndustrySectorName == sectorAlloc.IndustrySectorName &&
            c.InstrumentId == sectorAlloc.InstrumentId &&
            c.BbTicker == sectorAlloc.BbTicker &&
            c.AllocDate == sectorAlloc.AllocDate);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexInstrumentSectorAlloc)));
        }

        context.SaveChanges();
    }
    
    private static void LoadFundCode(PpcapitalContext context, DexFundCode fundCode)
    {
        var entry = context.DexFundCodes.AddIfNotExists(fundCode, c =>
            c.InstrumentId == fundCode.InstrumentId &&
            c.Isin == fundCode.Isin &&
            c.FundCode == fundCode.FundCode);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexFundCode)));
        }

        context.SaveChanges();
    }
    
    private static void LoadAssetClassAlloc(PpcapitalContext context, DexPpFundAssetClassAlloc assetClassAlloc)
    {
        var entry = context.DexPpFundAssetClassAllocs.DeleteIfExistsAndInsert(assetClassAlloc, c =>
            c.AssetClass == assetClassAlloc.AssetClass &&
            c.InstrumentId == assetClassAlloc.InstrumentId &&
            c.BbTicker == assetClassAlloc.BbTicker &&
            c.AllocDate == assetClassAlloc.AllocDate);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexPpFundAssetClassAlloc)));
        }

        context.SaveChanges();
    }
    
    private static void LoadBondCoupon(PpcapitalContext context, DexBondCoupon bondCoupon)
    {
        var entry = context.DexBondCoupons.AddIfNotExists(bondCoupon, bc =>
            bc.TradeDate == bondCoupon.TradeDate &&
            bc.ValueDate == bondCoupon.ValueDate &&
            bc.TradeTypeId == bondCoupon.TradeTypeId &&
            bc.AccountId == bondCoupon.AccountId &&
            bc.Currency == bondCoupon.Currency &&
            bc.InstrumentId == bondCoupon.InstrumentId &&
            Math.Abs((bc.Amount - bondCoupon.Amount) ?? 0) < 0.01
        );
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexBondCoupon)));
        }

        context.SaveChanges();
    }

    private static void LoadSecurityTransaction(PpcapitalContext context, DexSecurityTransaction transaction)
    {
        //context.DexSecurityTransactions.Add(transaction);
        var entry = context.DexSecurityTransactions.AddIfNotExists(transaction, securityTransaction =>
            securityTransaction.TradeDate == transaction.TradeDate &&
            securityTransaction.ValueDate == transaction.ValueDate &&
            securityTransaction.TradeTypeId == transaction.TradeTypeId &&
            securityTransaction.AccountId == transaction.AccountId &&
            securityTransaction.Currency == transaction.Currency &&
            securityTransaction.InstrumentId == transaction.InstrumentId &&
            Math.Abs(securityTransaction.Amount - transaction.Amount) < 0.01 &&
            Math.Abs(securityTransaction.Price - transaction.Price) < 0.01
        );

        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexSecurityTransaction)));
        }

        context.SaveChanges();
    }
    
    private static void LoadStagingSecurityTransaction(PpcapitalContext context, DexStagingSecurityTransaction transaction)
    {
        //context.DexSecurityTransactions.Add(transaction);
        var entry = context.DexStagingSecurityTransactions.AddIfNotExists(transaction, securityTransaction =>
            securityTransaction.TradeDate == transaction.TradeDate &&
            securityTransaction.ValueDate == transaction.ValueDate &&
            securityTransaction.TradeTypeName == transaction.TradeTypeName &&
            securityTransaction.Account == transaction.Account &&
            securityTransaction.Currency == transaction.Currency &&
            securityTransaction.Isin == transaction.Isin &&
            Math.Abs(securityTransaction.Amount - transaction.Amount) < 0.01 &&
            Math.Abs(securityTransaction.Price - transaction.Price) < 0.01
        );

        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexStagingSecurityTransaction)));
        }

        context.SaveChanges();
    }
    
    private static void LoadDividendTransaction(PpcapitalContext context, DexDividendTransaction transaction)
    {
        var entry = context.DexDividendTransactions.AddIfNotExists(transaction, dividendTransaction =>
            dividendTransaction.TradeDate == transaction.TradeDate &&
            dividendTransaction.ValueDate == transaction.ValueDate &&
            dividendTransaction.TradeTypeId == transaction.TradeTypeId &&
            dividendTransaction.AccountId == transaction.AccountId &&
            dividendTransaction.Currency == transaction.Currency &&
            dividendTransaction.InstrumentId == transaction.InstrumentId &&
            Math.Abs(dividendTransaction.Amount - transaction.Amount) < 0.01);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexDividendTransaction)));
        }

        context.SaveChanges();
    }
    
    private static void LoadStagingDividendTransaction(PpcapitalContext context, DexStagingDividendTransaction transaction)
    {
        var entry = context.DexStagingDividendTransactions.AddIfNotExists(transaction, dividendTransaction =>
            dividendTransaction.TradeDate == transaction.TradeDate &&
            dividendTransaction.ValueDate == transaction.ValueDate &&
            dividendTransaction.TradeTypeName == transaction.TradeTypeName &&
            dividendTransaction.Account == transaction.Account &&
            dividendTransaction.Currency == transaction.Currency &&
            dividendTransaction.Isin == transaction.Isin &&
            Math.Abs(dividendTransaction.Amount - transaction.Amount) < 0.01);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexStagingDividendTransaction)));
        }

        context.SaveChanges();
    }
    
    private static void LoadStagingCashTransaction(PpcapitalContext context, DexStagingCashTransaction cash)
    {
        // Do not match on trade type id, because transactions could have been labeled FX
        var entry = context.DexStagingCashTransactions.AddIfNotExists(cash, cashTransaction =>
            cashTransaction.TradeDate == cash.TradeDate &&
            cashTransaction.ValueDate == cash.ValueDate &&
            cashTransaction.Account == cash.Account &&
            cashTransaction.Currency == cash.Currency &&
            Math.Abs(cashTransaction.Amount - cash.Amount) < 0.01);
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexStagingCashTransaction)));
        }

        context.SaveChanges();
    }
    
    private static void LoadStagingBondCoupon(PpcapitalContext context, DexStagingBondCoupon bondCoupon)
    {
        // Do not match on trade type id, because transactions could have been labeled FX
        var entry = context.DexStagingBondCoupons.AddIfNotExists(bondCoupon, bc =>
            bc.TradeDate == bondCoupon.TradeDate &&
            bc.ValueDate == bondCoupon.ValueDate &&
            bc.TradeTypeId == bondCoupon.TradeTypeId &&
            bc.Account == bondCoupon.Account &&
            bc.Currency == bondCoupon.Currency &&
            bc.Isin == bondCoupon.Isin &&
            Math.Abs(bc.Amount - bondCoupon.Amount) < 0.01
        );
        
        if (entry == null)
        {
            throw new Exception(Consts.DuplicateIgnored(nameof(DexStagingBondCoupon)));
        }

        context.SaveChanges();
    }
}