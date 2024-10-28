using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Models;

public partial class PpcapitalContext : DbContext
{
    public PpcapitalContext()
    {
    }

    public PpcapitalContext(DbContextOptions<PpcapitalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActiveFundsPortfolioShare> ActiveFundsPortfolioShares { get; set; }

    public virtual DbSet<AifRealkreditCashExcelView> AifRealkreditCashExcelViews { get; set; }

    public virtual DbSet<AifRealkreditPortfolioExcelView> AifRealkreditPortfolioExcelViews { get; set; }

    public virtual DbSet<AifRealkreditTransactionsExcelView> AifRealkreditTransactionsExcelViews { get; set; }

    public virtual DbSet<AllClientTransaction> AllClientTransactions { get; set; }

    public virtual DbSet<AllocationInfo> AllocationInfos { get; set; }

    public virtual DbSet<AumOverview> AumOverviews { get; set; }

    public virtual DbSet<AumOverviewDepotToday> AumOverviewDepotTodays { get; set; }

    public virtual DbSet<AumReturnOverview> AumReturnOverviews { get; set; }

    public virtual DbSet<AumToday> AumTodays { get; set; }

    public virtual DbSet<BasisCashExcelView> BasisCashExcelViews { get; set; }

    public virtual DbSet<BasisMaCashView> BasisMaCashViews { get; set; }

    public virtual DbSet<BasisMaExcelHolding> BasisMaExcelHoldings { get; set; }

    public virtual DbSet<BasisPortfolioExcelView> BasisPortfolioExcelViews { get; set; }

    public virtual DbSet<BasisTransactionsExcelView> BasisTransactionsExcelViews { get; set; }

    public virtual DbSet<BmReturnsId> BmReturnsIds { get; set; }

    public virtual DbSet<BondCouponsView> BondCouponsViews { get; set; }

    public virtual DbSet<CashComparisonExtended> CashComparisonExtendeds { get; set; }

    public virtual DbSet<CashHoldingOverview> CashHoldingOverviews { get; set; }

    public virtual DbSet<CashHoldingsReporting> CashHoldingsReportings { get; set; }

    public virtual DbSet<CashTransactionsView> CashTransactionsViews { get; set; }

    public virtual DbSet<ClientAccountOverview> ClientAccountOverviews { get; set; }

    public virtual DbSet<ClientAccountOverviewAllocationark> ClientAccountOverviewAllocationarks { get; set; }

    public virtual DbSet<ClientAccountOverviewBasis> ClientAccountOverviewBases { get; set; }

    public virtual DbSet<ClientActualAumDkkDepot> ClientActualAumDkkDepots { get; set; }

    public virtual DbSet<ClientActualAumDkkId> ClientActualAumDkkIds { get; set; }

    public virtual DbSet<ClientActualAumRepCurDepot> ClientActualAumRepCurDepots { get; set; }

    public virtual DbSet<ClientActualAumRepCurId> ClientActualAumRepCurIds { get; set; }

    public virtual DbSet<ClientAumDepotReporting> ClientAumDepotReportings { get; set; }

    public virtual DbSet<ClientAumDepotReturnCalculation> ClientAumDepotReturnCalculations { get; set; }

    public virtual DbSet<ClientAumIdEomView> ClientAumIdEomViews { get; set; }

    public virtual DbSet<ClientAumRepCurDepot> ClientAumRepCurDepots { get; set; }

    public virtual DbSet<ClientDepotView> ClientDepotViews { get; set; }

    public virtual DbSet<ClientInfoView> ClientInfoViews { get; set; }

    public virtual DbSet<ClientLatestHolding> ClientLatestHoldings { get; set; }

    public virtual DbSet<ClientLatestProfile> ClientLatestProfiles { get; set; }

    public virtual DbSet<ClientMgmtFeeOverview> ClientMgmtFeeOverviews { get; set; }

    public virtual DbSet<ClientPerfFeeOverview> ClientPerfFeeOverviews { get; set; }

    public virtual DbSet<ClientReturnsDepotReporting> ClientReturnsDepotReportings { get; set; }

    public virtual DbSet<ClientReturnsIdReporting> ClientReturnsIdReportings { get; set; }

    public virtual DbSet<ClientTradedValueToday> ClientTradedValueTodays { get; set; }

    public virtual DbSet<CostsView> CostsViews { get; set; }

    public virtual DbSet<CounterpartView> CounterpartViews { get; set; }

    public virtual DbSet<CurrentlyActiveReturnDepot> CurrentlyActiveReturnDepots { get; set; }

    public virtual DbSet<DepotDatesOverview> DepotDatesOverviews { get; set; }

    public virtual DbSet<DexAccessTradeId> DexAccessTradeIds { get; set; }

    public virtual DbSet<DexAllocationLimitBase> DexAllocationLimitBases { get; set; }

    public virtual DbSet<DexBank> DexBanks { get; set; }

    public virtual DbSet<DexBankCost> DexBankCosts { get; set; }

    public virtual DbSet<DexBankHoldingsCash> DexBankHoldingsCashes { get; set; }

    public virtual DbSet<DexBankHoldingsInstrument> DexBankHoldingsInstruments { get; set; }

    public virtual DbSet<DexBm> DexBms { get; set; }

    public virtual DbSet<DexBmReturn> DexBmReturns { get; set; }

    public virtual DbSet<DexBmWeight> DexBmWeights { get; set; }

    public virtual DbSet<DexBondCoupon> DexBondCoupons { get; set; }

    public virtual DbSet<DexCashTransaction> DexCashTransactions { get; set; }

    public virtual DbSet<DexClientAccount> DexClientAccounts { get; set; }

    public virtual DbSet<DexClientAccountNew> DexClientAccountNews { get; set; }

    public virtual DbSet<DexClientAllocLimit> DexClientAllocLimits { get; set; }

    public virtual DbSet<DexClientAssetClassAlloc> DexClientAssetClassAllocs { get; set; }

    public virtual DbSet<DexClientAumDepot> DexClientAumDepots { get; set; }

    public virtual DbSet<DexClientAumId> DexClientAumIds { get; set; }

    public virtual DbSet<DexClientBenchmark> DexClientBenchmarks { get; set; }

    public virtual DbSet<DexClientCashHolding> DexClientCashHoldings { get; set; }

    public virtual DbSet<DexClientContact> DexClientContacts { get; set; }

    public virtual DbSet<DexClientCountryAlloc> DexClientCountryAllocs { get; set; }

    public virtual DbSet<DexClientCouponAlloc> DexClientCouponAllocs { get; set; }

    public virtual DbSet<DexClientDepot> DexClientDepots { get; set; }

    public virtual DbSet<DexClientDepotDate> DexClientDepotDates { get; set; }

    public virtual DbSet<DexClientDepotsNew> DexClientDepotsNews { get; set; }

    public virtual DbSet<DexClientFeeCap> DexClientFeeCaps { get; set; }

    public virtual DbSet<DexClientFeeFilter> DexClientFeeFilters { get; set; }

    public virtual DbSet<DexClientFeeFixed> DexClientFeeFixeds { get; set; }

    public virtual DbSet<DexClientFeeStructure> DexClientFeeStructures { get; set; }

    public virtual DbSet<DexClientFeeTransfer> DexClientFeeTransfers { get; set; }

    public virtual DbSet<DexClientFtNumber> DexClientFtNumbers { get; set; }

    public virtual DbSet<DexClientInfo> DexClientInfos { get; set; }

    public virtual DbSet<DexClientInstHolding> DexClientInstHoldings { get; set; }

    public virtual DbSet<DexClientMarginStructure> DexClientMarginStructures { get; set; }

    public virtual DbSet<DexClientPartner> DexClientPartners { get; set; }

    public virtual DbSet<DexClientProfile> DexClientProfiles { get; set; }

    public virtual DbSet<DexClientReporting> DexClientReportings { get; set; }

    public virtual DbSet<DexClientReturnGroup> DexClientReturnGroups { get; set; }

    public virtual DbSet<DexClientReturnsDepot> DexClientReturnsDepots { get; set; }

    public virtual DbSet<DexClientReturnsId> DexClientReturnsIds { get; set; }

    public virtual DbSet<DexClientSectorAlloc> DexClientSectorAllocs { get; set; }

    public virtual DbSet<DexClientVat> DexClientVats { get; set; }

    public virtual DbSet<DexComparisonsCash> DexComparisonsCashes { get; set; }

    public virtual DbSet<DexComparisonsInstrument> DexComparisonsInstruments { get; set; }

    public virtual DbSet<DexContact> DexContacts { get; set; }

    public virtual DbSet<DexCost> DexCosts { get; set; }

    public virtual DbSet<DexCostType> DexCostTypes { get; set; }

    public virtual DbSet<DexCountry> DexCountries { get; set; }

    public virtual DbSet<DexCurrency> DexCurrencies { get; set; }

    public virtual DbSet<DexCurrencyPair> DexCurrencyPairs { get; set; }

    public virtual DbSet<DexDepotType> DexDepotTypes { get; set; }

    public virtual DbSet<DexDividendTransaction> DexDividendTransactions { get; set; }

    public virtual DbSet<DexEmployee> DexEmployees { get; set; }

    public virtual DbSet<DexExchangeRate> DexExchangeRates { get; set; }

    public virtual DbSet<DexFtDeductionCap> DexFtDeductionCaps { get; set; }

    public virtual DbSet<DexFtDeductionCpn> DexFtDeductionCpns { get; set; }

    public virtual DbSet<DexFundCode> DexFundCodes { get; set; }

    public virtual DbSet<DexFundÅop> DexFundÅops { get; set; }

    public virtual DbSet<DexInstrument> DexInstruments { get; set; }

    public virtual DbSet<DexInstrumentCntryAlloc> DexInstrumentCntryAllocs { get; set; }

    public virtual DbSet<DexInstrumentMcapAlloc> DexInstrumentMcapAllocs { get; set; }

    public virtual DbSet<DexInstrumentPrice> DexInstrumentPrices { get; set; }

    public virtual DbSet<DexInstrumentSectorAlloc> DexInstrumentSectorAllocs { get; set; }

    public virtual DbSet<DexInstrumentsNew> DexInstrumentsNews { get; set; }

    public virtual DbSet<DexInstrumentsSfdr> DexInstrumentsSfdrs { get; set; }

    public virtual DbSet<DexInstrumentsUnlisted> DexInstrumentsUnlisteds { get; set; }

    public virtual DbSet<DexIntranetUser> DexIntranetUsers { get; set; }

    public virtual DbSet<DexManager> DexManagers { get; set; }

    public virtual DbSet<DexMgmtPerfFee> DexMgmtPerfFees { get; set; }

    public virtual DbSet<DexPartner> DexPartners { get; set; }

    public virtual DbSet<DexPeCommitment> DexPeCommitments { get; set; }

    public virtual DbSet<DexPolicy> DexPolicies { get; set; }

    public virtual DbSet<DexPpFeeType> DexPpFeeTypes { get; set; }

    public virtual DbSet<DexPpFundAssetClassAlloc> DexPpFundAssetClassAllocs { get; set; }

    public virtual DbSet<DexProfileAllocation> DexProfileAllocations { get; set; }

    public virtual DbSet<DexProfileAllocationSe> DexProfileAllocationSes { get; set; }

    public virtual DbSet<DexProfileProductAllocation> DexProfileProductAllocations { get; set; }

    public virtual DbSet<DexProgress> DexProgresses { get; set; }

    public virtual DbSet<DexReturnDate> DexReturnDates { get; set; }

    public virtual DbSet<DexReturnGroup> DexReturnGroups { get; set; }

    public virtual DbSet<DexSecurityTransaction> DexSecurityTransactions { get; set; }

    public virtual DbSet<DexStagingBondCoupon> DexStagingBondCoupons { get; set; }

    public virtual DbSet<DexStagingCashTransaction> DexStagingCashTransactions { get; set; }

    public virtual DbSet<DexStagingCost> DexStagingCosts { get; set; }

    public virtual DbSet<DexStagingDividendTransaction> DexStagingDividendTransactions { get; set; }

    public virtual DbSet<DexStagingSecurityTransaction> DexStagingSecurityTransactions { get; set; }

    public virtual DbSet<DexTodaysTransaction> DexTodaysTransactions { get; set; }

    public virtual DbSet<DexTradeTypeBil> DexTradeTypeBils { get; set; }

    public virtual DbSet<DexTradeTypeEfg> DexTradeTypeEfgs { get; set; }

    public virtual DbSet<DexTradeTypeId> DexTradeTypeIds { get; set; }

    public virtual DbSet<DexTradeTypeJyske> DexTradeTypeJyskes { get; set; }

    public virtual DbSet<DexTradeTypeNew> DexTradeTypeNews { get; set; }

    public virtual DbSet<DexTradeTypeNordnet> DexTradeTypeNordnets { get; set; }

    public virtual DbSet<DexTradeTypeNordnetSe> DexTradeTypeNordnetSes { get; set; }

    public virtual DbSet<DexTradeTypeRilba> DexTradeTypeRilbas { get; set; }

    public virtual DbSet<DexTradeTypeSaxo> DexTradeTypeSaxos { get; set; }

    public virtual DbSet<DexTradeTypeSparnord> DexTradeTypeSparnords { get; set; }

    public virtual DbSet<DexTradeTypeVp> DexTradeTypeVps { get; set; }

    public virtual DbSet<DexTransactionTable> DexTransactionTables { get; set; }

    public virtual DbSet<DividendTransactionsView> DividendTransactionsViews { get; set; }

    public virtual DbSet<EomClientReturnOverviewRepCur> EomClientReturnOverviewRepCurs { get; set; }

    public virtual DbSet<EomDepotReturnOverviewRepCur> EomDepotReturnOverviewRepCurs { get; set; }

    public virtual DbSet<EomReturnDate> EomReturnDates { get; set; }

    public virtual DbSet<FundHolding> FundHoldings { get; set; }

    public virtual DbSet<FundReturn> FundReturns { get; set; }

    public virtual DbSet<FxToday> FxTodays { get; set; }

    public virtual DbSet<HoldingsListedUnlisted> HoldingsListedUnlisteds { get; set; }

    public virtual DbSet<HoldingsPpfundsEom> HoldingsPpfundsEoms { get; set; }

    public virtual DbSet<IncomeBankIdView> IncomeBankIdViews { get; set; }

    public virtual DbSet<IncomeOverview> IncomeOverviews { get; set; }

    public virtual DbSet<IndtjeningPerCappedKunde> IndtjeningPerCappedKundes { get; set; }

    public virtual DbSet<InstrumentBeholdningsoversigtRepCur> InstrumentBeholdningsoversigtRepCurs { get; set; }

    public virtual DbSet<InstrumentHoldingsOverview> InstrumentHoldingsOverviews { get; set; }

    public virtual DbSet<InstrumentHoldingsReportingValuation> InstrumentHoldingsReportingValuations { get; set; }

    public virtual DbSet<InstrumentHoldingsVallerod> InstrumentHoldingsVallerods { get; set; }

    public virtual DbSet<InstrumentPricesWithTickersAndIsin> InstrumentPricesWithTickersAndIsins { get; set; }

    public virtual DbSet<InstrumentPricesWithTickersAndIsinToday> InstrumentPricesWithTickersAndIsinTodays { get; set; }

    public virtual DbSet<InstrumentsComparisonExtended> InstrumentsComparisonExtendeds { get; set; }

    public virtual DbSet<InstrumentsSfdr> InstrumentsSfdrs { get; set; }

    public virtual DbSet<InstrumentsWithAssetClass> InstrumentsWithAssetClasses { get; set; }

    public virtual DbSet<IntranetAssetClassAlloc> IntranetAssetClassAllocs { get; set; }

    public virtual DbSet<IntranetAssetClassLimitsLatest> IntranetAssetClassLimitsLatests { get; set; }

    public virtual DbSet<IntranetAssetClassLimitsLatestBreach> IntranetAssetClassLimitsLatestBreaches { get; set; }

    public virtual DbSet<IntranetAumBankDistribution> IntranetAumBankDistributions { get; set; }

    public virtual DbSet<IntranetAumDashboard> IntranetAumDashboards { get; set; }

    public virtual DbSet<IntranetCashExposureCheck> IntranetCashExposureChecks { get; set; }

    public virtual DbSet<IntranetCashOverdraftCheck> IntranetCashOverdraftChecks { get; set; }

    public virtual DbSet<IntranetClientAccountOverview> IntranetClientAccountOverviews { get; set; }

    public virtual DbSet<IntranetClientAumDepot> IntranetClientAumDepots { get; set; }

    public virtual DbSet<IntranetClientAumId> IntranetClientAumIds { get; set; }

    public virtual DbSet<IntranetClientBenchmark> IntranetClientBenchmarks { get; set; }

    public virtual DbSet<IntranetClientOverview> IntranetClientOverviews { get; set; }

    public virtual DbSet<IntranetClientReturnsId> IntranetClientReturnsIds { get; set; }

    public virtual DbSet<IntranetCurrencyExposure> IntranetCurrencyExposures { get; set; }

    public virtual DbSet<IntranetDeposit> IntranetDeposits { get; set; }

    public virtual DbSet<IntranetIncomeOverview> IntranetIncomeOverviews { get; set; }

    public virtual DbSet<IntranetLatestCountryAlloc> IntranetLatestCountryAllocs { get; set; }

    public virtual DbSet<IntranetLatestSectorAlloc> IntranetLatestSectorAllocs { get; set; }

    public virtual DbSet<IntranetPeOverview> IntranetPeOverviews { get; set; }

    public virtual DbSet<IntranetPolicyCashCheck> IntranetPolicyCashChecks { get; set; }

    public virtual DbSet<KursAvanceOverview> KursAvanceOverviews { get; set; }

    public virtual DbSet<LastestInstrumentValuationRepCur> LastestInstrumentValuationRepCurs { get; set; }

    public virtual DbSet<LatestAvailableInstrumentHolding> LatestAvailableInstrumentHoldings { get; set; }

    public virtual DbSet<LatestCashHolding> LatestCashHoldings { get; set; }

    public virtual DbSet<LatestCashHoldingsDkk> LatestCashHoldingsDkks { get; set; }

    public virtual DbSet<LatestClientAggCashHoldingsDkk> LatestClientAggCashHoldingsDkks { get; set; }

    public virtual DbSet<LatestClientAssetClassAlloc> LatestClientAssetClassAllocs { get; set; }

    public virtual DbSet<LatestClientFtNumber> LatestClientFtNumbers { get; set; }

    public virtual DbSet<LatestClientInstHolding> LatestClientInstHoldings { get; set; }

    public virtual DbSet<LatestFundCashHolding> LatestFundCashHoldings { get; set; }

    public virtual DbSet<LatestFundInstHolding> LatestFundInstHoldings { get; set; }

    public virtual DbSet<LatestInstrumentHolding> LatestInstrumentHoldings { get; set; }

    public virtual DbSet<LatestInstrumentHoldingsValuationDkk> LatestInstrumentHoldingsValuationDkks { get; set; }

    public virtual DbSet<LatestInstrumentPricesWithTickersAndIsin> LatestInstrumentPricesWithTickersAndIsins { get; set; }

    public virtual DbSet<MgmtFeeCalcCashHolding> MgmtFeeCalcCashHoldings { get; set; }

    public virtual DbSet<MgmtFeeCalcInstHolding> MgmtFeeCalcInstHoldings { get; set; }

    public virtual DbSet<MgmtPerfFeesView> MgmtPerfFeesViews { get; set; }

    public virtual DbSet<OnTopOverview> OnTopOverviews { get; set; }

    public virtual DbSet<RealrådView> RealrådViews { get; set; }

    public virtual DbSet<ReturnGroupOverview> ReturnGroupOverviews { get; set; }

    public virtual DbSet<ReturnOverviewToTeam> ReturnOverviewToTeams { get; set; }

    public virtual DbSet<SecurityTransactionsAmountDkk> SecurityTransactionsAmountDkks { get; set; }

    public virtual DbSet<SecurityTransactionsView> SecurityTransactionsViews { get; set; }

    public virtual DbSet<StockpickCashExcelView> StockpickCashExcelViews { get; set; }

    public virtual DbSet<StockpickPortfolioExcelView> StockpickPortfolioExcelViews { get; set; }

    public virtual DbSet<StockpickTransactionsExcelView> StockpickTransactionsExcelViews { get; set; }

    public virtual DbSet<TaktikCashExcelView> TaktikCashExcelViews { get; set; }

    public virtual DbSet<TaktikPortfolioExcelView> TaktikPortfolioExcelViews { get; set; }

    public virtual DbSet<TaktikTransactionsExcelView> TaktikTransactionsExcelViews { get; set; }

    public virtual DbSet<TotalClientInflowOutflowOverview> TotalClientInflowOutflowOverviews { get; set; }

    public virtual DbSet<TradingBookActiveAccount> TradingBookActiveAccounts { get; set; }

    public virtual DbSet<TradingBookActiveInstrumentsWithLatestPrice> TradingBookActiveInstrumentsWithLatestPrices { get; set; }

    public virtual DbSet<TradingBookMarginOverview> TradingBookMarginOverviews { get; set; }

    public virtual DbSet<TradingBookMonthlyDkkReturn> TradingBookMonthlyDkkReturns { get; set; }

    public virtual DbSet<TransactionListView> TransactionListViews { get; set; }

    public virtual DbSet<TurnoverOverview> TurnoverOverviews { get; set; }

    public virtual DbSet<UnderlyingFundCashHolding> UnderlyingFundCashHoldings { get; set; }

    public virtual DbSet<UnderlyingFundCashHoldingsWithPct> UnderlyingFundCashHoldingsWithPcts { get; set; }

    public virtual DbSet<VallerodAssetClassesAlloc> VallerodAssetClassesAllocs { get; set; }

    public virtual DbSet<VallerodBenchmarkReturn> VallerodBenchmarkReturns { get; set; }

    public virtual DbSet<VallerodInstrumentHoldingsAsset> VallerodInstrumentHoldingsAssets { get; set; }

    public virtual DbSet<VallerodTransactionsAsset> VallerodTransactionsAssets { get; set; }

    public virtual DbSet<VallerodTransactionsAssetsFinal> VallerodTransactionsAssetsFinals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActiveFundsPortfolioShare>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("active_funds_portfolio_share");

            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.PortfolioSharePercent).HasColumnName("PORTFOLIO_SHARE_PERCENT");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
        });

        modelBuilder.Entity<AifRealkreditCashExcelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("aif_realkredit_cash_excel_view");

            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AmountAccCur).HasColumnName("AMOUNT_ACC_CUR");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
        });

        modelBuilder.Entity<AifRealkreditPortfolioExcelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("aif_realkredit_portfolio_excel_view");

            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
        });

        modelBuilder.Entity<AifRealkreditTransactionsExcelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("aif_realkredit_transactions_excel_view");

            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.AmountDkk).HasColumnName("AMOUNT_DKK");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.ExRate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("EX_RATE");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeName)
                .HasMaxLength(255)
                .HasColumnName("TRADE_TYPE_NAME");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<AllClientTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("all_client_transactions");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.AmountRepCur).HasColumnName("AMOUNT_REP_CUR");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.ClassificationLevel4Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_4_name");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DEPOT_ID");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.InterestRepCur).HasColumnName("INTEREST_REP_CUR");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.TradeDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
        });

        modelBuilder.Entity<AllocationInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("allocation_info");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Iban)
                .HasMaxLength(40)
                .HasColumnName("IBAN");
        });

        modelBuilder.Entity<AumOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("aum_overview");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.AumDkk).HasColumnName("AUM_DKK");
            entity.Property(e => e.AumExPpFundDkk).HasColumnName("AUM_EX_PP_FUND_DKK");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.Hurdle).HasColumnName("HURDLE");
            entity.Property(e => e.InOutDkk).HasColumnName("IN_OUT_DKK");
            entity.Property(e => e.MgmtFee).HasColumnName("MGMT_FEE");
            entity.Property(e => e.MmFundDkk).HasColumnName("MM_FUND_DKK");
            entity.Property(e => e.PerformanceFee).HasColumnName("PERFORMANCE_FEE");
            entity.Property(e => e.PpFundDkk).HasColumnName("PP_FUND_DKK");
        });

        modelBuilder.Entity<AumOverviewDepotToday>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("aum_overview_depot_today");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.AumDkk).HasColumnName("AUM_DKK");
            entity.Property(e => e.AumExPpFundDkk).HasColumnName("AUM_EX_PP_FUND_DKK");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.Hurdle).HasColumnName("HURDLE");
            entity.Property(e => e.InOutDkk).HasColumnName("IN_OUT_DKK");
            entity.Property(e => e.MgmtFee).HasColumnName("MGMT_FEE");
            entity.Property(e => e.MmFundDkk).HasColumnName("MM_FUND_DKK");
            entity.Property(e => e.PerformanceFee).HasColumnName("PERFORMANCE_FEE");
            entity.Property(e => e.PpFundDkk).HasColumnName("PP_FUND_DKK");
        });

        modelBuilder.Entity<AumReturnOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("aum_return_overview");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.AumDkk).HasColumnName("AUM_DKK");
            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.ClientType)
                .HasMaxLength(45)
                .HasColumnName("CLIENT_TYPE");
            entity.Property(e => e.ContractType)
                .HasMaxLength(45)
                .HasColumnName("CONTRACT_TYPE");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.InOutDkk).HasColumnName("IN_OUT_DKK");
            entity.Property(e => e.MmFundDkk).HasColumnName("MM_FUND_DKK");
            entity.Property(e => e.PpFundDkk).HasColumnName("PP_FUND_DKK");
            entity.Property(e => e.ReturnDkk).HasColumnName("RETURN_DKK");
            entity.Property(e => e.ReturnPct).HasColumnName("RETURN_PCT");
            entity.Property(e => e.TimeUsed)
                .HasMaxLength(1)
                .HasColumnName("TIME_USED");
        });

        modelBuilder.Entity<AumToday>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("aum_today");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.CashDkk).HasColumnName("CASH_DKK");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.InOutDkk).HasColumnName("IN_OUT_DKK");
            entity.Property(e => e.InstDkk).HasColumnName("INST_DKK");
            entity.Property(e => e.TotalAumDkk).HasColumnName("TOTAL_AUM_DKK");
        });

        modelBuilder.Entity<BasisCashExcelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("basis_cash_excel_view");

            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AmountAccCur).HasColumnName("AMOUNT_ACC_CUR");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
        });

        modelBuilder.Entity<BasisMaCashView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("basis_ma_cash_view");

            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AmountAccCur).HasColumnName("AMOUNT_ACC_CUR");
            entity.Property(e => e.AmountDkk).HasColumnName("AMOUNT_DKK");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
        });

        modelBuilder.Entity<BasisMaExcelHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("basis_ma_excel_holdings");

            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.BpipeReferenceSecurityClass)
                .HasMaxLength(45)
                .HasColumnName("bpipe_reference_security_class");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
        });

        modelBuilder.Entity<BasisPortfolioExcelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("basis_portfolio_excel_view");

            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
        });

        modelBuilder.Entity<BasisTransactionsExcelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("basis_transactions_excel_view");

            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeName)
                .HasMaxLength(255)
                .HasColumnName("TRADE_TYPE_NAME");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<BmReturnsId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("bm_returns_id");

            entity.Property(e => e.BmId).HasColumnName("BM_ID");
            entity.Property(e => e.BmModDur).HasColumnName("BM_MOD_DUR");
            entity.Property(e => e.BmName)
                .HasMaxLength(255)
                .HasColumnName("BM_NAME");
            entity.Property(e => e.BmReturn).HasColumnName("BM_RETURN");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.ReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
        });

        modelBuilder.Entity<BondCouponsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("bond_coupons_view");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.PpTransaction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<CashComparisonExtended>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cash_comparison_extended");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.BankAmount)
                .HasPrecision(20)
                .HasColumnName("BANK_AMOUNT");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.Diff)
                .HasPrecision(20)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("DIFF");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("date")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("date")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.PpAmount)
                .HasPrecision(20)
                .HasColumnName("PP_AMOUNT");
            entity.Property(e => e.Resolved).HasColumnName("RESOLVED");
            entity.Property(e => e.Value)
                .HasPrecision(20)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<CashHoldingOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cash_holding_overview");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AmountAccCur).HasColumnName("AMOUNT_ACC_CUR");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DEPOT_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
        });

        modelBuilder.Entity<CashHoldingsReporting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cash_holdings_reporting");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AmountAccCur).HasColumnName("AMOUNT_ACC_CUR");
            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.ExRate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("EX_RATE");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.ReturnGroup).HasColumnName("RETURN_GROUP");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
            entity.Property(e => e.ValueReportingCurrency).HasColumnName("VALUE_REPORTING_CURRENCY");
        });

        modelBuilder.Entity<CashTransactionsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("cash_transactions_view");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("COMMENT");
            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.PpTransaction).HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<ClientAccountOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_account_overview");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.DepotTypeId).HasColumnName("DEPOT_TYPE_ID");
            entity.Property(e => e.Iban)
                .HasMaxLength(40)
                .HasColumnName("IBAN");
        });

        modelBuilder.Entity<ClientAccountOverviewAllocationark>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_account_overview_allocationark");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.DepotTypeId).HasColumnName("DEPOT_TYPE_ID");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.Iban)
                .HasMaxLength(40)
                .HasColumnName("IBAN");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
        });

        modelBuilder.Entity<ClientAccountOverviewBasis>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_account_overview_basis");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.DepotTypeId).HasColumnName("DEPOT_TYPE_ID");
            entity.Property(e => e.Iban)
                .HasMaxLength(40)
                .HasColumnName("IBAN");
        });

        modelBuilder.Entity<ClientActualAumDkkDepot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_actual_aum_dkk_depot");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.CashDkk).HasColumnName("CASH_DKK");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.InOutDkk).HasColumnName("IN_OUT_DKK");
            entity.Property(e => e.InstDkk).HasColumnName("INST_DKK");
            entity.Property(e => e.TotalAumDkk).HasColumnName("TOTAL_AUM_DKK");
        });

        modelBuilder.Entity<ClientActualAumDkkId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_actual_aum_dkk_id");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.CashDkk).HasColumnName("CASH_DKK");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.InOutDkk).HasColumnName("IN_OUT_DKK");
            entity.Property(e => e.InstDkk).HasColumnName("INST_DKK");
            entity.Property(e => e.TotalAumDkk).HasColumnName("TOTAL_AUM_DKK");
        });

        modelBuilder.Entity<ClientActualAumRepCurDepot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_actual_aum_rep_cur_depot");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.CashRepCur).HasColumnName("CASH_REP_CUR");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.InOutRepCur).HasColumnName("IN_OUT_REP_CUR");
            entity.Property(e => e.InstRepCur).HasColumnName("INST_REP_CUR");
            entity.Property(e => e.TotalAumRepCur).HasColumnName("TOTAL_AUM_REP_CUR");
        });

        modelBuilder.Entity<ClientActualAumRepCurId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_actual_aum_rep_cur_id");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.CashRepCur).HasColumnName("CASH_REP_CUR");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.InOutRepCur).HasColumnName("IN_OUT_REP_CUR");
            entity.Property(e => e.InstRepCur).HasColumnName("INST_REP_CUR");
            entity.Property(e => e.TotalAumRepCur).HasColumnName("TOTAL_AUM_REP_CUR");
        });

        modelBuilder.Entity<ClientAumDepotReporting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_aum_depot_reporting");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.CashDkk).HasColumnName("CASH_DKK");
            entity.Property(e => e.CashRepCur).HasColumnName("CASH_REP_CUR");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotType)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InOut).HasColumnName("IN_OUT");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstDkk).HasColumnName("INST_DKK");
            entity.Property(e => e.InstRepCur).HasColumnName("INST_REP_CUR");
            entity.Property(e => e.TotalAumDkk).HasColumnName("TOTAL_AUM_DKK");
            entity.Property(e => e.TotalAumRepCur).HasColumnName("TOTAL_AUM_REP_CUR");
        });

        modelBuilder.Entity<ClientAumDepotReturnCalculation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_aum_depot_return_calculation");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.AumDkkActualDepot).HasColumnName("AUM_DKK_ACTUAL_DEPOT");
            entity.Property(e => e.AumDkkWCashDepot).HasColumnName("AUM_DKK_W_CASH_DEPOT");
            entity.Property(e => e.AumDkkWoCashDepot).HasColumnName("AUM_DKK_WO_CASH_DEPOT");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.CashDkkDepot).HasColumnName("CASH_DKK_DEPOT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.IoDkkActualDepot).HasColumnName("IO_DKK_ACTUAL_DEPOT");
            entity.Property(e => e.IoDkkWCashDepot).HasColumnName("IO_DKK_W_CASH_DEPOT");
            entity.Property(e => e.IoDkkWoCashDepot).HasColumnName("IO_DKK_WO_CASH_DEPOT");
            entity.Property(e => e.MmFundDkk).HasColumnName("MM_FUND_DKK");
            entity.Property(e => e.PpFundDkk).HasColumnName("PP_FUND_DKK");
            entity.Property(e => e.ReturnGroup).HasColumnName("RETURN_GROUP");
        });

        modelBuilder.Entity<ClientAumIdEomView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_aum_id_eom_view");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.AumDkk).HasColumnName("AUM_DKK");
            entity.Property(e => e.CashDkk).HasColumnName("CASH_DKK");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.FundsOnly).HasColumnName("FUNDS_ONLY");
            entity.Property(e => e.InOutDkk).HasColumnName("IN_OUT_DKK");
            entity.Property(e => e.InstDkk).HasColumnName("INST_DKK");
            entity.Property(e => e.MmFundDkk).HasColumnName("MM_FUND_DKK");
            entity.Property(e => e.Month).HasColumnName("MONTH");
            entity.Property(e => e.PpFundDkk).HasColumnName("PP_FUND_DKK");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<ClientAumRepCurDepot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_aum_rep_cur_depot");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.CashRepCur).HasColumnName("CASH_REP_CUR");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.InOutRepCur).HasColumnName("IN_OUT_REP_CUR");
            entity.Property(e => e.InstRepCur).HasColumnName("INST_REP_CUR");
            entity.Property(e => e.TotalAumRepCur).HasColumnName("TOTAL_AUM_REP_CUR");
        });

        modelBuilder.Entity<ClientDepotView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_depot_view");

            entity.Property(e => e.Active)
                .HasMaxLength(8)
                .HasColumnName("ACTIVE");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeId).HasColumnName("DEPOT_TYPE_ID");
        });

        modelBuilder.Entity<ClientInfoView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_info_view");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("CITY");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.ClientType)
                .HasMaxLength(45)
                .HasColumnName("CLIENT_TYPE");
            entity.Property(e => e.ContractType)
                .HasMaxLength(45)
                .HasColumnName("CONTRACT_TYPE");
            entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");
            entity.Property(e => e.Cvr)
                .HasMaxLength(20)
                .HasColumnName("CVR");
            entity.Property(e => e.ManagerId).HasColumnName("MANAGER_ID");
            entity.Property(e => e.OnTop).HasColumnName("ON_TOP");
            entity.Property(e => e.PartnerId).HasColumnName("PARTNER_ID");
            entity.Property(e => e.TimeUsed)
                .HasMaxLength(1)
                .HasColumnName("TIME_USED");
            entity.Property(e => e.Zip)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<ClientLatestHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_latest_holdings");

            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.PctShare).HasColumnName("pct_share");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
        });

        modelBuilder.Entity<ClientLatestProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_latest_profiles");

            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.RiskProfile)
                .HasMaxLength(45)
                .HasColumnName("RISK_PROFILE");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("TO_DATE");
        });

        modelBuilder.Entity<ClientMgmtFeeOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_mgmt_fee_overview");

            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.FeeAmount).HasColumnName("FEE_AMOUNT");
            entity.Property(e => e.FeeType)
                .HasMaxLength(45)
                .HasColumnName("FEE_TYPE");
        });

        modelBuilder.Entity<ClientPerfFeeOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_perf_fee_overview");

            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.FeeAmount).HasColumnName("FEE_AMOUNT");
            entity.Property(e => e.FeeType)
                .HasMaxLength(45)
                .HasColumnName("FEE_TYPE");
        });

        modelBuilder.Entity<ClientReturnsDepotReporting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_returns_depot_reporting");

            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DEPOT_ID");
            entity.Property(e => e.FxEffectRepCur).HasColumnName("FX_EFFECT_REP_CUR");
            entity.Property(e => e.GrossDepotReturnRepCur).HasColumnName("GROSS_DEPOT_RETURN_REP_CUR");
            entity.Property(e => e.GrossPortfolioAttrReturn).HasColumnName("GROSS_PORTFOLIO_ATTR_RETURN");
            entity.Property(e => e.RepCurReturnActual).HasColumnName("REP_CUR_RETURN_ACTUAL");
            entity.Property(e => e.RepCurReturnActualExFx).HasColumnName("REP_CUR_RETURN_ACTUAL_EX_FX");
            entity.Property(e => e.ReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
        });

        modelBuilder.Entity<ClientReturnsIdReporting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_returns_id_reporting");

            entity.Property(e => e.AumDkkT1).HasColumnName("AUM_DKK_T1");
            entity.Property(e => e.BmId).HasColumnName("BM_ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.DkkReturnActual).HasColumnName("DKK_RETURN_ACTUAL");
            entity.Property(e => e.ExRate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("EX_RATE");
            entity.Property(e => e.ExRatePrev).HasColumnName("EX_RATE_PREV");
            entity.Property(e => e.FxEffectRepCur).HasColumnName("FX_EFFECT_REP_CUR");
            entity.Property(e => e.FxRet).HasColumnName("FX_RET");
            entity.Property(e => e.GrossBmReturnRepCur).HasColumnName("GROSS_BM_RETURN_REP_CUR");
            entity.Property(e => e.GrossExRateReturn).HasColumnName("GROSS_EX_RATE_RETURN");
            entity.Property(e => e.GrossPortfolioReturnRepCur).HasColumnName("GROSS_PORTFOLIO_RETURN_REP_CUR");
            entity.Property(e => e.RepCurReturn).HasColumnName("REP_CUR_RETURN");
            entity.Property(e => e.RepCurReturnExFx).HasColumnName("REP_CUR_RETURN_EX_FX");
            entity.Property(e => e.ReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
        });

        modelBuilder.Entity<ClientTradedValueToday>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("client_traded_value_today");

            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
        });

        modelBuilder.Entity<CostsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("costs_view");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AddToCostOverview)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ADD_TO_COST_OVERVIEW");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.BankCostId).HasColumnName("BANK_COST_ID");
            entity.Property(e => e.BankCostName)
                .HasMaxLength(255)
                .HasColumnName("BANK_COST_NAME");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.CostTypeName)
                .HasMaxLength(80)
                .HasColumnName("COST_TYPE_NAME");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DexTableId).HasColumnName("DEX_TABLE_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.PpTransaction).HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId)
                .HasDefaultValueSql("'8'")
                .HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<CounterpartView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("counterpart_view");

            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.CountryName)
                .HasMaxLength(45)
                .HasColumnName("COUNTRY_NAME");
            entity.Property(e => e.Ec)
                .HasMaxLength(255)
                .HasColumnName("EC");
            entity.Property(e => e.JbCode)
                .HasMaxLength(255)
                .HasColumnName("JB_CODE");
        });

        modelBuilder.Entity<CurrentlyActiveReturnDepot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("currently_active_return_depots");

            entity.Property(e => e.Active)
                .HasMaxLength(8)
                .HasDefaultValueSql("''")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
        });

        modelBuilder.Entity<DepotDatesOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("depot_dates_overview");

            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.IdDepotDates).HasColumnName("ID_DEPOT_DATES");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
        });

        modelBuilder.Entity<DexAccessTradeId>(entity =>
        {
            entity.HasKey(e => e.HandelsIk).HasName("PRIMARY");

            entity.ToTable("dex_access_trade_ids");

            entity.HasIndex(e => e.TradeTypeId, "accesstradeid_tradetypeid_tradetypeid_idx");

            entity.Property(e => e.HandelsIk).HasColumnName("HANDELS_IK");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexAccessTradeIds)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accesstradeid_tradetypeid_tradetypeid");
        });

        modelBuilder.Entity<DexAllocationLimitBase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_allocation_limit_base");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.ClientProfile)
                .HasMaxLength(45)
                .HasColumnName("CLIENT_PROFILE");
            entity.Property(e => e.MaxLimit).HasColumnName("MAX_LIMIT");
            entity.Property(e => e.MinLimit).HasColumnName("MIN_LIMIT");
        });

        modelBuilder.Entity<DexBank>(entity =>
        {
            entity.HasKey(e => e.BankId).HasName("PRIMARY");

            entity.ToTable("dex_bank");

            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.CountryName)
                .HasMaxLength(45)
                .HasColumnName("COUNTRY_NAME");
            entity.Property(e => e.Ec)
                .HasMaxLength(255)
                .HasColumnName("EC");
            entity.Property(e => e.JbCode)
                .HasMaxLength(255)
                .HasColumnName("JB_CODE");
        });

        modelBuilder.Entity<DexBankCost>(entity =>
        {
            entity.HasKey(e => e.BankCostId).HasName("PRIMARY");

            entity.ToTable("dex_bank_costs");

            entity.HasIndex(e => e.BankId, "BANK_ID");

            entity.HasIndex(e => e.CostTypeId, "COST_ID");

            entity.Property(e => e.BankCostId).HasColumnName("BANK_COST_ID");
            entity.Property(e => e.AddToCostOverview)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ADD_TO_COST_OVERVIEW");
            entity.Property(e => e.BankCostDescription)
                .HasMaxLength(255)
                .HasColumnName("BANK_COST_DESCRIPTION");
            entity.Property(e => e.BankCostName)
                .HasMaxLength(255)
                .HasColumnName("BANK_COST_NAME");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.CostTypeId).HasColumnName("COST_TYPE_ID");

            entity.HasOne(d => d.Bank).WithMany(p => p.DexBankCosts)
                .HasForeignKey(d => d.BankId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bankcosts_bankid");

            entity.HasOne(d => d.CostType).WithMany(p => p.DexBankCosts)
                .HasForeignKey(d => d.CostTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bankcosts_costtype_costid");
        });

        modelBuilder.Entity<DexBankHoldingsCash>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_bank_holdings_cash");

            entity.HasIndex(e => e.AccountId, "fk_bankholdingscash_accounts_accountid_idx");

            entity.HasIndex(e => e.Currency, "fk_bankholdingscash_currency_currency_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("date")
                .HasColumnName("HOLDING_DATE");

            entity.HasOne(d => d.Account).WithMany(p => p.DexBankHoldingsCashes)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_bankholdingscash_accounts_accountid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexBankHoldingsCashes)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_bankholdingscash_currency_currency");
        });

        modelBuilder.Entity<DexBankHoldingsInstrument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_bank_holdings_instrument");

            entity.HasIndex(e => e.AccountId, "fk_bankholdingsinstrument_accounts_accountid_idx");

            entity.HasIndex(e => e.Currency, "fk_bankholdingsinstrument_currency_currency_idx");

            entity.HasIndex(e => e.InstrumentId, "fk_bankholdingsinstrument_instrument_instrumentid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("date")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

            entity.HasOne(d => d.Account).WithMany(p => p.DexBankHoldingsInstruments)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_bankholdingsinstrument_accounts_accountid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexBankHoldingsInstruments)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_bankholdingsinstrument_currency_currency");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexBankHoldingsInstruments)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_bankholdingsinstrument_instruments_instrumentid");
        });

        modelBuilder.Entity<DexBm>(entity =>
        {
            entity.HasKey(e => e.BmId).HasName("PRIMARY");

            entity.ToTable("dex_bm");

            entity.Property(e => e.BmId).HasColumnName("BM_ID");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.BmLongName)
                .HasMaxLength(255)
                .HasColumnName("BM_LONG_NAME");
            entity.Property(e => e.BmName)
                .HasMaxLength(255)
                .HasColumnName("BM_NAME");
        });

        modelBuilder.Entity<DexBmReturn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_bm_returns");

            entity.HasIndex(e => e.ReturnDate, "bmreturns_returndate_index");

            entity.HasIndex(e => e.BmId, "fk_bmreturns_bm_bmid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BmId).HasColumnName("BM_ID");
            entity.Property(e => e.BmModDur).HasColumnName("BM_MOD_DUR");
            entity.Property(e => e.BmReturn).HasColumnName("BM_RETURN");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.ReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");

            entity.HasOne(d => d.Bm).WithMany(p => p.DexBmReturns)
                .HasForeignKey(d => d.BmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bmreturns_bm_bmid");
        });

        modelBuilder.Entity<DexBmWeight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_bm_weights");

            entity.HasIndex(e => e.BmId, "BM_ID");

            entity.HasIndex(e => e.InstrumentId, "fk_bmweights_instruments_instrumentid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(255)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.BmId).HasColumnName("BM_ID");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.WeightPct).HasColumnName("WEIGHT_PCT");

            entity.HasOne(d => d.Bm).WithMany(p => p.DexBmWeights)
                .HasForeignKey(d => d.BmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bmweights_bm_bmid");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexBmWeights)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bmweights_instruments_instrumentid");
        });

        modelBuilder.Entity<DexBondCoupon>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PRIMARY");

            entity.ToTable("dex_bond_coupons");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.HasIndex(e => e.InstrumentId, "bondcoupons_instrument_id");

            entity.HasIndex(e => e.TradeDate, "bondcoupons_tradedate_index");

            entity.HasIndex(e => e.AccountId, "fk_bondcoupons_accountid_idx");

            entity.HasIndex(e => e.Currency, "fk_bondcoupons_currency_currency");

            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'0'")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Currency).HasColumnName("CURRENCY");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.PpTransaction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");

            entity.HasOne(d => d.Account).WithMany(p => p.DexBondCoupons)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bondcoupons_accountid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexBondCoupons)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bondcoupons_currency_currency");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexBondCoupons)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bondcoupons_instruments_instrumentid");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexBondCoupons)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bondcoupons_tradetypeid_tradetypeid");
        });

        modelBuilder.Entity<DexCashTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PRIMARY");

            entity.ToTable("dex_cash_transactions");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.HasIndex(e => e.TradeDate, "cashtransactions_tradedate_index");

            entity.HasIndex(e => e.Currency, "fk_cashtransaction_currency_currency");

            entity.HasIndex(e => e.AccountId, "fk_cashtransactions_accountid_idx");

            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("COMMENT");
            entity.Property(e => e.Currency).HasColumnName("CURRENCY");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.PpTransaction).HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");

            entity.HasOne(d => d.Account).WithMany(p => p.DexCashTransactions)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cashtransactions_accountid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexCashTransactions)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cashtransaction_currency_currency");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexCashTransactions)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cashtransaction_tradetypeid_tradetypeid");
        });

        modelBuilder.Entity<DexClientAccount>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PRIMARY");

            entity.ToTable("dex_client_account");

            entity.HasIndex(e => e.Currency, "clientaccounts_currency_idx");

            entity.HasIndex(e => e.DepotId, "clientaccounts_depotid_idx");

            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.Iban)
                .HasMaxLength(40)
                .HasColumnName("IBAN");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexClientAccounts)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientaccount_currency_currency");

            entity.HasOne(d => d.Depot).WithMany(p => p.DexClientAccounts)
                .HasForeignKey(d => d.DepotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientaccount_clientdepots_depotid");
        });

        modelBuilder.Entity<DexClientAccountNew>(entity =>
        {
            entity.HasKey(e => e.NewAccountId).HasName("PRIMARY");

            entity.ToTable("dex_client_account_new");

            entity.HasIndex(e => e.DepotId, "clientaccountnew_depotid_idx");

            entity.Property(e => e.NewAccountId).HasColumnName("NEW_ACCOUNT_ID");
            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.Iban)
                .HasMaxLength(40)
                .HasColumnName("IBAN");
            entity.Property(e => e.InputDate)
                .HasColumnType("date")
                .HasColumnName("INPUT_DATE");

            entity.HasOne(d => d.Depot).WithMany(p => p.DexClientAccountNews)
                .HasForeignKey(d => d.DepotId)
                .HasConstraintName("clientaccountnew_depotid");
        });

        modelBuilder.Entity<DexClientAllocLimit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_alloc_limits");

            entity.HasIndex(e => e.ClientPpId, "fk_clientalloclimits_clientppid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.MaxLimit).HasColumnName("MAX_LIMIT");
            entity.Property(e => e.MinLimit).HasColumnName("MIN_LIMIT");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientAllocLimits)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientalloclimits_clientinfo_clientppid");
        });

        modelBuilder.Entity<DexClientAssetClassAlloc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_asset_class_alloc");

            entity.HasIndex(e => e.AllocDate, "clientassetclassalloc_holdingdate_index");

            entity.HasIndex(e => e.ClientPpId, "fk_clientassetclassalloc_clientinfo_clientppid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.AssetClassPct).HasColumnName("ASSET_CLASS_PCT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientAssetClassAllocs)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientassetclassalloc_clientinfo_clientppid");
        });

        modelBuilder.Entity<DexClientAumDepot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_aum_depot");

            entity.HasIndex(e => new { e.AumDate, e.DepotId }, "aumdate_depotid_index");

            entity.HasIndex(e => e.AumDate, "clientaumdepot_aumdate_index");

            entity.HasIndex(e => e.DepotId, "fk_clientaumdepot_depotid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.CashDkk).HasColumnName("CASH_DKK");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.InOutDkkWCash).HasColumnName("IN_OUT_DKK_W_CASH");
            entity.Property(e => e.InOutDkkWoCash).HasColumnName("IN_OUT_DKK_WO_CASH");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstDkk).HasColumnName("INST_DKK");
            entity.Property(e => e.MmFundDkk).HasColumnName("MM_FUND_DKK");
            entity.Property(e => e.PpFundDkk).HasColumnName("PP_FUND_DKK");
            entity.Property(e => e.TotalAumDkk).HasColumnName("TOTAL_AUM_DKK");

            entity.HasOne(d => d.Depot).WithMany(p => p.DexClientAumDepots)
                .HasForeignKey(d => d.DepotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientaumdepot_depotid");
        });

        modelBuilder.Entity<DexClientAumId>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_aum_id");

            entity.HasIndex(e => e.AumDate, "clientaumid_aumdate_index");

            entity.HasIndex(e => new { e.AumDate, e.ClientPpId }, "clientppid_aumdate_index");

            entity.HasIndex(e => e.ClientPpId, "fk_clientaumid_clientinfo_clientppid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.CashDkk).HasColumnName("CASH_DKK");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.InOutDkkWCash).HasColumnName("IN_OUT_DKK_W_CASH");
            entity.Property(e => e.InOutDkkWoCash).HasColumnName("IN_OUT_DKK_WO_CASH");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstDkk).HasColumnName("INST_DKK");
            entity.Property(e => e.MmFundDkk).HasColumnName("MM_FUND_DKK");
            entity.Property(e => e.PpFundDkk).HasColumnName("PP_FUND_DKK");
            entity.Property(e => e.TotalAumDkk).HasColumnName("TOTAL_AUM_DKK");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientAumIds)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientaumid_clientinfo_clientppid");
        });

        modelBuilder.Entity<DexClientBenchmark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_benchmark");

            entity.HasIndex(e => e.BmId, "fk_clientbenchmark_bm_bmid");

            entity.HasIndex(e => e.ClientPpId, "fk_clientbenchmark_clientinfo_clientppid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BmId).HasColumnName("BM_ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("END_DATE");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("START_DATE");

            entity.HasOne(d => d.Bm).WithMany(p => p.DexClientBenchmarks)
                .HasForeignKey(d => d.BmId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientbenchmark_bm_bmid");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientBenchmarks)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientbenchmark_clientinfo_clientppid");
        });

        modelBuilder.Entity<DexClientCashHolding>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_cash_holdings");

            entity.HasIndex(e => e.HoldingDate, "clientcashholdings_holdingdate_index");

            entity.HasIndex(e => e.AccountId, "fk_clientcashholdings_accountid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AmountAccCur).HasColumnName("AMOUNT_ACC_CUR");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");

            entity.HasOne(d => d.Account).WithMany(p => p.DexClientCashHoldings)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientcashholdings_accountid");
        });

        modelBuilder.Entity<DexClientContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_contact");

            entity.HasIndex(e => e.ClientPpId, "clientcontact_clientinfo_clientppid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(60)
                .HasColumnName("CONTACT_EMAIL");
            entity.Property(e => e.ContactFirstName)
                .HasMaxLength(60)
                .HasColumnName("CONTACT_FIRST_NAME");
            entity.Property(e => e.ContactFullName)
                .HasMaxLength(60)
                .HasColumnName("CONTACT_FULL_NAME");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(45)
                .HasColumnName("CONTACT_PHONE");
            entity.Property(e => e.ReceiveReporting)
                .HasDefaultValueSql("'1'")
                .HasColumnName("RECEIVE_REPORTING");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientContacts)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientcontact_clientinfo_clientppid");
        });

        modelBuilder.Entity<DexClientCountryAlloc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_country_alloc");

            entity.HasIndex(e => e.AllocDate, "clientcountryalloc_allocdate_index");

            entity.HasIndex(e => e.ClientPpId, "clientcountryalloc_clientinfo_clientppid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.CountryWeightAlloc).HasColumnName("country_weight_alloc");
            entity.Property(e => e.GeographicalRegion)
                .HasMaxLength(45)
                .HasColumnName("geographical_region");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientCountryAllocs)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientcountryalloc_clientinfo_clientppid");
        });

        modelBuilder.Entity<DexClientCouponAlloc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_coupon_alloc");

            entity.HasIndex(e => e.ClientPpId, "clientcouponalloc_clientinfo_clientppid");

            entity.HasIndex(e => e.AllocDate, "clientcouponalloc_holdingdate_index");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.AllocPct).HasColumnName("ALLOC_PCT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.CouponType)
                .HasMaxLength(45)
                .HasColumnName("COUPON_TYPE");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientCouponAllocs)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientcouponalloc_clientinfo_clientppid");
        });

        modelBuilder.Entity<DexClientDepot>(entity =>
        {
            entity.HasKey(e => e.DepotId).HasName("PRIMARY");

            entity.ToTable("dex_client_depots");

            entity.HasIndex(e => e.ClientPpId, "fk_clientdepot_clientinfo_client_pp_id_idx");

            entity.HasIndex(e => e.BankId, "fk_clientdepots_bank_bankid_idx");

            entity.HasIndex(e => e.DepotTypeId, "fk_clientdepots_depottype_depottypeid_idx");

            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotTypeId).HasColumnName("DEPOT_TYPE_ID");
            entity.Property(e => e.Recalculate).HasColumnName("RECALCULATE");
            entity.Property(e => e.RecalculateFromDate)
                .HasColumnType("date")
                .HasColumnName("RECALCULATE_FROM_DATE");

            entity.HasOne(d => d.Bank).WithMany(p => p.DexClientDepots)
                .HasForeignKey(d => d.BankId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientdepots_bank_bankid");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientDepots)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientdepots_clientinfo_clientppid");

            entity.HasOne(d => d.DepotType).WithMany(p => p.DexClientDepots)
                .HasForeignKey(d => d.DepotTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientdepots_depottype_depottypeid");
        });

        modelBuilder.Entity<DexClientDepotDate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_depot_dates");

            entity.HasIndex(e => e.DepotId, "clientdepotdates_depotid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");

            entity.HasOne(d => d.Depot).WithMany(p => p.DexClientDepotDates)
                .HasForeignKey(d => d.DepotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientdepotdates_depotid");
        });

        modelBuilder.Entity<DexClientDepotsNew>(entity =>
        {
            entity.HasKey(e => e.NewDepotId).HasName("PRIMARY");

            entity.ToTable("dex_client_depots_new");

            entity.HasIndex(e => e.BankId, "clientdepotsnew_bank_bankid_idx");

            entity.HasIndex(e => e.ClientPpId, "clientdepotsnew_clientinfo_client_pp_id_idx");

            entity.HasIndex(e => e.DepotTypeId, "clientdepotsnew_depottype_depottypeid_idx");

            entity.Property(e => e.NewDepotId).HasColumnName("NEW_DEPOT_ID");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotTypeId).HasColumnName("DEPOT_TYPE_ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("date")
                .HasColumnName("INPUT_DATE");

            entity.HasOne(d => d.Bank).WithMany(p => p.DexClientDepotsNews)
                .HasForeignKey(d => d.BankId)
                .HasConstraintName("clientdepotsnew_bank_bankid");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientDepotsNews)
                .HasForeignKey(d => d.ClientPpId)
                .HasConstraintName("fk_clientdepotsnew_clientinfo_clientppid");

            entity.HasOne(d => d.DepotType).WithMany(p => p.DexClientDepotsNews)
                .HasForeignKey(d => d.DepotTypeId)
                .HasConstraintName("fk_clientdepotsnew_depottype_depottypeid");
        });

        modelBuilder.Entity<DexClientFeeCap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_fee_caps");

            entity.HasIndex(e => e.ClientPpId, "client_fee_caps_client_info_client_pp_id_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.CapType)
                .HasMaxLength(10)
                .HasColumnName("CAP_TYPE");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.FeeType)
                .HasMaxLength(45)
                .HasColumnName("FEE_TYPE");
            entity.Property(e => e.Horizon)
                .HasMaxLength(20)
                .HasColumnName("HORIZON");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientFeeCaps)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("client_fee_caps_client_info_client_pp_id");
        });

        modelBuilder.Entity<DexClientFeeFilter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_fee_filters");

            entity.HasIndex(e => e.DepotId, "clientfeefilters_depotid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.CountryIso)
                .HasMaxLength(5)
                .HasColumnName("COUNTRY_ISO");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.FeeAmount).HasColumnName("FEE_AMOUNT");
            entity.Property(e => e.FeeType)
                .HasMaxLength(45)
                .HasColumnName("FEE_TYPE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.SpecialCase)
                .HasMaxLength(45)
                .HasColumnName("SPECIAL_CASE");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");

            entity.HasOne(d => d.Depot).WithMany(p => p.DexClientFeeFilters)
                .HasForeignKey(d => d.DepotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientfeefilters_clientdepots_depotid");
        });

        modelBuilder.Entity<DexClientFeeFixed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_fee_fixed");

            entity.HasIndex(e => e.DepotId, "clientfeefixed_depotid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.FeeType)
                .HasMaxLength(45)
                .HasColumnName("FEE_TYPE");
            entity.Property(e => e.Frequency).HasColumnName("FREQUENCY");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
        });

        modelBuilder.Entity<DexClientFeeStructure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_fee_structure");

            entity.HasIndex(e => e.DepotId, "clientfeestructure_depotid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.FeeAmount).HasColumnName("FEE_AMOUNT");
            entity.Property(e => e.FeeType)
                .HasMaxLength(45)
                .HasColumnName("FEE_TYPE");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");

            entity.HasOne(d => d.Depot).WithMany(p => p.DexClientFeeStructures)
                .HasForeignKey(d => d.DepotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientfeestructure_depotid");
        });

        modelBuilder.Entity<DexClientFeeTransfer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_fee_transfer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DepotIdFrom).HasColumnName("DEPOT_ID_FROM");
            entity.Property(e => e.DepotIdTo).HasColumnName("DEPOT_ID_TO");
        });

        modelBuilder.Entity<DexClientFtNumber>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_ft_numbers");

            entity.HasIndex(e => e.HoldingDate, "clientftnumbers_holdingdate_index");

            entity.HasIndex(e => e.ClientPpId, "fk_clientftnumbers_clientppid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.FtRenterisikoTotal).HasColumnName("FT Renterisiko Total");
            entity.Property(e => e.FtRenterisikoÆndring).HasColumnName("FT Renterisiko ændring");
            entity.Property(e => e.FtVar).HasColumnName("FT_VAR");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.KurslisteTotal).HasColumnName("Kursliste Total");
            entity.Property(e => e.KurslisteÆndring).HasColumnName("Kursliste ændring");
            entity.Property(e => e.ModelbaseretTotal).HasColumnName("Modelbaseret Total");
            entity.Property(e => e.ModelbaseretÆndring).HasColumnName("Modelbaseret ændring");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientFtNumbers)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientftnumbers_clientppid");
        });

        modelBuilder.Entity<DexClientInfo>(entity =>
        {
            entity.HasKey(e => e.ClientPpId).HasName("PRIMARY");

            entity.ToTable("dex_client_info");

            entity.HasIndex(e => e.CountryId, "COUNTRY_ID");

            entity.HasIndex(e => e.ManagerId, "dk_clientinfo_managerid_idx");

            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("ADDRESS");
            entity.Property(e => e.BillingCurrency)
                .HasMaxLength(3)
                .HasDefaultValueSql("'DKK'")
                .HasColumnName("BILLING_CURRENCY");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("CITY");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientType)
                .HasMaxLength(45)
                .HasColumnName("CLIENT_TYPE");
            entity.Property(e => e.ContractType)
                .HasMaxLength(45)
                .HasColumnName("CONTRACT_TYPE");
            entity.Property(e => e.CountryId).HasColumnName("COUNTRY_ID");
            entity.Property(e => e.Cvr)
                .HasMaxLength(20)
                .HasColumnName("CVR");
            entity.Property(e => e.ManagerId).HasColumnName("MANAGER_ID");
            entity.Property(e => e.TimeUsed)
                .HasMaxLength(1)
                .HasColumnName("TIME_USED");
            entity.Property(e => e.Zip)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0'")
                .HasColumnName("ZIP");

            entity.HasOne(d => d.Country).WithMany(p => p.DexClientInfos)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientinfo_country_countryid");

            entity.HasOne(d => d.Manager).WithMany(p => p.DexClientInfos)
                .HasForeignKey(d => d.ManagerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dk_clientinfo_managerid");
        });

        modelBuilder.Entity<DexClientInstHolding>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_inst_holdings");

            entity.HasIndex(e => e.HoldingDate, "clientinst_holdings_holdingsdat_index");

            entity.HasIndex(e => e.InstrumentId, "clientinst_instrumentid");

            entity.HasIndex(e => e.DepotId, "fk_clientinstholdings_clientdepots_depotid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

            entity.HasOne(d => d.Depot).WithMany(p => p.DexClientInstHoldings)
                .HasForeignKey(d => d.DepotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientinstholdings_clientdepots_depotid");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexClientInstHoldings)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientinstholdings_instruments_instrumentid");
        });

        modelBuilder.Entity<DexClientMarginStructure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_margin_structure");

            entity.HasIndex(e => e.ClientPpId, "fk_clientmarginstructure_clientppid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.FeeAmount).HasColumnName("FEE_AMOUNT");
            entity.Property(e => e.FeeType)
                .HasMaxLength(45)
                .HasColumnName("FEE_TYPE");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientMarginStructures)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientmarginstructure_clientppid");
        });

        modelBuilder.Entity<DexClientPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_partner");

            entity.HasIndex(e => e.ClientPpId, "client_partner_client_pp_id_fk_idx");

            entity.HasIndex(e => e.PartnerId, "client_partner_partner_id_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.FeeSharingFrequency)
                .HasMaxLength(1)
                .HasColumnName("FEE_SHARING_FREQUENCY");
            entity.Property(e => e.IsFeeSharing).HasColumnName("IS_FEE_SHARING");
            entity.Property(e => e.PartnerId).HasColumnName("PARTNER_ID");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientPartners)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientpartner_clientppid_fk");

            entity.HasOne(d => d.Partner).WithMany(p => p.DexClientPartners)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("clientpartner_partnerid_fk");
        });

        modelBuilder.Entity<DexClientProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_profile");

            entity.HasIndex(e => e.ClientPpId, "fk_clientprofile_clientppid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.FromDate)
                .HasColumnType("datetime")
                .HasColumnName("FROM_DATE");
            entity.Property(e => e.RiskProfile)
                .HasMaxLength(45)
                .HasColumnName("RISK_PROFILE");
            entity.Property(e => e.ToDate)
                .HasColumnType("datetime")
                .HasColumnName("TO_DATE");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientProfiles)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientprofile_clientppid");
        });

        modelBuilder.Entity<DexClientReporting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_reporting");

            entity.HasIndex(e => e.ClientPpId, "fk_clientreporting_clientppid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.FiscalYearEnd).HasColumnName("FISCAL_YEAR_END");
            entity.Property(e => e.MergeRealerStater).HasColumnName("MERGE_REALER_STATER");
            entity.Property(e => e.QuarterlyReporting).HasColumnName("QUARTERLY_REPORTING");
            entity.Property(e => e.ReportingCurrency)
                .HasMaxLength(3)
                .HasColumnName("REPORTING_CURRENCY");
            entity.Property(e => e.WantExcel).HasColumnName("WANT_EXCEL");
            entity.Property(e => e.WantReporting).HasColumnName("WANT_REPORTING");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientReportings)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientreporting_clientppid");
        });

        modelBuilder.Entity<DexClientReturnGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_return_group");

            entity.HasIndex(e => e.DepotId, "fk_clientreturngroup_depotid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.ReturnGroup).HasColumnName("RETURN_GROUP");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");

            entity.HasOne(d => d.Depot).WithMany(p => p.DexClientReturnGroups)
                .HasForeignKey(d => d.DepotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientreturngroup_depotid");
        });

        modelBuilder.Entity<DexClientReturnsDepot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_returns_depot");

            entity.HasIndex(e => e.ReturnDate, "clientreturnsdepot_returndate_index");

            entity.HasIndex(e => e.DepotId, "fk_clientreturnsdepot_depotid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotReturnActual).HasColumnName("DEPOT_RETURN_ACTUAL");
            entity.Property(e => e.DepotReturnWCash).HasColumnName("DEPOT_RETURN_W_CASH");
            entity.Property(e => e.DepotReturnWoCash).HasColumnName("DEPOT_RETURN_WO_CASH");
            entity.Property(e => e.DkkReturnActual).HasColumnName("DKK_RETURN_ACTUAL");
            entity.Property(e => e.DkkReturnWCash).HasColumnName("DKK_RETURN_W_CASH");
            entity.Property(e => e.DkkReturnWoCash).HasColumnName("DKK_RETURN_WO_CASH");
            entity.Property(e => e.PortfolioReturnAttrActual)
                .HasComment("Depending on return group on given return date, this column will correspond to either PORTFOLIO_RETURN_ATTR_W_CASH or PORTFOLIO_RETURN_ATTR_WO_CASH")
                .HasColumnName("PORTFOLIO_RETURN_ATTR_ACTUAL");
            entity.Property(e => e.PortfolioReturnAttrWCash).HasColumnName("PORTFOLIO_RETURN_ATTR_W_CASH");
            entity.Property(e => e.PortfolioReturnAttrWoCash).HasColumnName("PORTFOLIO_RETURN_ATTR_WO_CASH");
            entity.Property(e => e.ReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
            entity.Property(e => e.SigIoActualDepot).HasColumnName("SIG_IO_ACTUAL_DEPOT");
            entity.Property(e => e.SigIoWCashDepot).HasColumnName("SIG_IO_W_CASH_DEPOT");
            entity.Property(e => e.SigIoWoCashDepot).HasColumnName("SIG_IO_WO_CASH_DEPOT");
            entity.Property(e => e.WActual).HasColumnName("W_ACTUAL");
            entity.Property(e => e.WWCash).HasColumnName("W_W_CASH");
            entity.Property(e => e.WWoCash).HasColumnName("W_WO_CASH");

            entity.HasOne(d => d.Depot).WithMany(p => p.DexClientReturnsDepots)
                .HasForeignKey(d => d.DepotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientreturnsdepot_depotid");
        });

        modelBuilder.Entity<DexClientReturnsId>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_returns_id");

            entity.HasIndex(e => e.ClientPpId, "clientreturnsid_clientppid");

            entity.HasIndex(e => e.ReturnDate, "clientreturnsid_returndate_index");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.DkkReturnActual).HasColumnName("DKK_RETURN_ACTUAL");
            entity.Property(e => e.DkkReturnWCash).HasColumnName("DKK_RETURN_W_CASH");
            entity.Property(e => e.DkkReturnWoCash).HasColumnName("DKK_RETURN_WO_CASH");
            entity.Property(e => e.PortfolioReturnActual).HasColumnName("PORTFOLIO_RETURN_ACTUAL");
            entity.Property(e => e.PortfolioReturnWCash).HasColumnName("PORTFOLIO_RETURN_W_CASH");
            entity.Property(e => e.PortfolioReturnWoCash).HasColumnName("PORTFOLIO_RETURN_WO_CASH");
            entity.Property(e => e.ReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
            entity.Property(e => e.SigIoActualId).HasColumnName("SIG_IO_ACTUAL_ID");
            entity.Property(e => e.SigIoWCashId).HasColumnName("SIG_IO_W_CASH_ID");
            entity.Property(e => e.SigIoWoCashId).HasColumnName("SIG_IO_WO_CASH_ID");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientReturnsIds)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientreturnsid_clientinfo_clientppid");
        });

        modelBuilder.Entity<DexClientSectorAlloc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_sector_alloc", tb => tb.HasComment("Table contains information about underlying fund exposure. "));

            entity.HasIndex(e => e.AllocDate, "clientsectoralloc_allocdate_index");

            entity.HasIndex(e => e.ClientPpId, "fk_clientsectoralloc_clientppid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.IndustrySectorName)
                .HasMaxLength(60)
                .HasColumnName("industry_sector_name");
            entity.Property(e => e.InstSectorWeightAlloc).HasColumnName("inst_sector_weight_alloc");

            entity.HasOne(d => d.ClientPp).WithMany(p => p.DexClientSectorAllocs)
                .HasForeignKey(d => d.ClientPpId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clientsectoralloc_clientppid");
        });

        modelBuilder.Entity<DexClientVat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_client_vat");

            entity.HasIndex(e => e.DepotId, "fk_vat_depotid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.Vat).HasColumnName("VAT");

            entity.HasOne(d => d.Depot).WithMany(p => p.DexClientVats)
                .HasForeignKey(d => d.DepotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_vat_depotid");
        });

        modelBuilder.Entity<DexComparisonsCash>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_comparisons_cash");

            entity.HasIndex(e => e.Id, "ID_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.BankAmount)
                .HasPrecision(20)
                .HasColumnName("BANK_AMOUNT");
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Diff)
                .HasPrecision(20)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("DIFF");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("date")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InputDate)
                .HasColumnType("date")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.PpAmount)
                .HasPrecision(20)
                .HasColumnName("PP_AMOUNT");
            entity.Property(e => e.Resolved).HasColumnName("RESOLVED");
            entity.Property(e => e.Value)
                .HasPrecision(20)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<DexComparisonsInstrument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_comparisons_instruments");

            entity.HasIndex(e => e.Id, "ID_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BankQuantity)
                .HasPrecision(20)
                .HasColumnName("BANK_QUANTITY");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.Diff)
                .HasPrecision(20)
                .HasColumnName("DIFF");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("date")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InputDate)
                .HasColumnType("date")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.PpQuantity)
                .HasPrecision(20)
                .HasColumnName("PP_QUANTITY");
            entity.Property(e => e.Resolved)
                .HasDefaultValueSql("b'0'")
                .HasColumnType("bit(1)")
                .HasColumnName("RESOLVED");
            entity.Property(e => e.Value)
                .HasPrecision(20)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<DexContact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PRIMARY");

            entity.ToTable("dex_contact");

            entity.Property(e => e.ContactId).HasColumnName("CONTACT_ID");
            entity.Property(e => e.ContactEmail)
                .HasMaxLength(45)
                .HasColumnName("CONTACT_EMAIL");
            entity.Property(e => e.ContactFirstName)
                .HasMaxLength(45)
                .HasColumnName("CONTACT_FIRST_NAME");
            entity.Property(e => e.ContactFullName)
                .HasMaxLength(45)
                .HasColumnName("CONTACT_FULL_NAME");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(45)
                .HasColumnName("CONTACT_PHONE");
        });

        modelBuilder.Entity<DexCost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_costs");

            entity.HasIndex(e => e.TransactionId, "TRANSACTION_ID");

            entity.HasIndex(e => e.TradeDate, "costs_tradedate_index");

            entity.HasIndex(e => e.AccountId, "fk_costs_accountid_idx");

            entity.HasIndex(e => e.BankCostId, "fk_costs_bankcostid_idx");

            entity.HasIndex(e => e.Currency, "fk_costs_currency_currency_idx");

            entity.HasIndex(e => e.TradeTypeId, "fk_costs_tradetypeid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.BankCostId).HasColumnName("BANK_COST_ID");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.DexTableId).HasColumnName("DEX_TABLE_ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.PpTransaction).HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId)
                .HasDefaultValueSql("'8'")
                .HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");

            entity.HasOne(d => d.Account).WithMany(p => p.DexCosts)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_costs_accountid");

            entity.HasOne(d => d.BankCost).WithMany(p => p.DexCosts)
                .HasForeignKey(d => d.BankCostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_costs_bankcostid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexCosts)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_costs_currency_currency");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexCosts)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_costs_tradetypeid");
        });

        modelBuilder.Entity<DexCostType>(entity =>
        {
            entity.HasKey(e => e.CostTypeId).HasName("PRIMARY");

            entity.ToTable("dex_cost_types");

            entity.Property(e => e.CostTypeId).HasColumnName("COST_TYPE_ID");
            entity.Property(e => e.CostTypeName)
                .HasMaxLength(80)
                .HasColumnName("COST_TYPE_NAME");
            entity.Property(e => e.CostTypeNameDa)
                .HasMaxLength(80)
                .HasColumnName("COST_TYPE_NAME_DA");
        });

        modelBuilder.Entity<DexCountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_country");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.Iso)
                .HasMaxLength(255)
                .HasColumnName("ISO");
            entity.Property(e => e.ShortName)
                .HasMaxLength(255)
                .HasColumnName("SHORT_NAME");
        });

        modelBuilder.Entity<DexCurrency>(entity =>
        {
            entity.HasKey(e => e.Currency).HasName("PRIMARY");

            entity.ToTable("dex_currency");

            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.CurrencyName)
                .HasMaxLength(255)
                .HasColumnName("CURRENCY_NAME");
        });

        modelBuilder.Entity<DexCurrencyPair>(entity =>
        {
            entity.HasKey(e => e.Currency).HasName("PRIMARY");

            entity.ToTable("dex_currency_pairs");

            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
        });

        modelBuilder.Entity<DexDepotType>(entity =>
        {
            entity.HasKey(e => e.DepotTypeId).HasName("PRIMARY");

            entity.ToTable("dex_depot_type");

            entity.HasIndex(e => e.DepotTypeId, "ACCOUNT_TYPE_ID");

            entity.Property(e => e.DepotTypeId).HasColumnName("DEPOT_TYPE_ID");
            entity.Property(e => e.DepotType)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
        });

        modelBuilder.Entity<DexDividendTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PRIMARY");

            entity.ToTable("dex_dividend_transactions");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.HasIndex(e => e.TradeDate, "dividendtransactions_tradedate_index");

            entity.HasIndex(e => e.AccountId, "fk_dividendtransactions_accountid_idx");

            entity.HasIndex(e => e.Currency, "fk_dividendtransactions_currency_currency_idx");

            entity.HasIndex(e => e.InstrumentId, "fk_dividendtransactions_instrumentid");

            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.CashImpact)
                .HasDefaultValueSql("'1'")
                .HasColumnName("CASH_IMPACT");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Currency).HasColumnName("CURRENCY");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.PpTransaction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");

            entity.HasOne(d => d.Account).WithMany(p => p.DexDividendTransactions)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dividendtransactions_accountid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexDividendTransactions)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dividendtransactions_currency_currency");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexDividendTransactions)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dividendtransactions_instrumentid");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexDividendTransactions)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dividendtransactions_tradetypeid");
        });

        modelBuilder.Entity<DexEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_employees");

            entity.HasIndex(e => e.Email, "email");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .HasColumnName("country");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
        });

        modelBuilder.Entity<DexExchangeRate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_exchange_rates");

            entity.HasIndex(e => new { e.ExRateDate, e.Currency }, "exchangerate_exratedate_currency_index");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.ExRate).HasColumnName("EX_RATE");
            entity.Property(e => e.ExRateDate)
                .HasColumnType("datetime")
                .HasColumnName("EX_RATE_DATE");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
        });

        modelBuilder.Entity<DexFtDeductionCap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_ft_deduction_cap");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cap).HasColumnName("CAP");
            entity.Property(e => e.DateFrom)
                .HasColumnType("datetime")
                .HasColumnName("DATE_FROM");
            entity.Property(e => e.DateTo)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TO");
            entity.Property(e => e.Deduction).HasColumnName("DEDUCTION");
        });

        modelBuilder.Entity<DexFtDeductionCpn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_ft_deduction_cpn");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Coupon).HasColumnName("COUPON");
            entity.Property(e => e.DateFrom)
                .HasColumnType("datetime")
                .HasColumnName("DATE_FROM");
            entity.Property(e => e.DateTo)
                .HasColumnType("datetime")
                .HasColumnName("DATE_TO");
            entity.Property(e => e.Maturity10).HasColumnName("maturity_10");
            entity.Property(e => e.Maturity1020).HasColumnName("maturity_10_20");
            entity.Property(e => e.Maturity20).HasColumnName("maturity_20_");
        });

        modelBuilder.Entity<DexFundCode>(entity =>
        {
            entity.HasKey(e => e.FundCode).HasName("PRIMARY");

            entity.ToTable("dex_fund_code");

            entity.HasIndex(e => e.InstrumentId, "INSTRUMENT_ID");

            entity.Property(e => e.FundCode).HasColumnName("FUND_CODE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(255)
                .HasColumnName("ISIN");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexFundCodes)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dex_fund_code_ibfk_1");
        });

        modelBuilder.Entity<DexFundÅop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_fund_åop");

            entity.HasIndex(e => e.InstrumentId, "dex_fund_åop_instruments_instrumentid_fk");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.LøbendeFee3rd).HasColumnName("LØBENDE_FEE_3RD");
            entity.Property(e => e.LøbendeFeePp).HasColumnName("LØBENDE_FEE_PP");
            entity.Property(e => e.LøbendeFeeTotal).HasColumnName("LØBENDE_FEE_TOTAL");
            entity.Property(e => e.PerformanceFee).HasColumnName("PERFORMANCE_FEE");
            entity.Property(e => e.Year).HasColumnName("YEAR");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexFundÅops)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dex_fund_åop_instruments_instrumentid_fk");
        });

        modelBuilder.Entity<DexInstrument>(entity =>
        {
            entity.HasKey(e => e.InstrumentId).HasName("PRIMARY");

            entity.ToTable("dex_instruments");

            entity.HasIndex(e => e.BbTicker, "instruments_bbticker_index");

            entity.HasIndex(e => e.Isin, "instruments_isin_ticker");

            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.BicsLevel1SectorName)
                .HasMaxLength(45)
                .HasColumnName("bics_level_1_sector_name");
            entity.Property(e => e.BicsLevel2IndustryGroupName)
                .HasMaxLength(45)
                .HasColumnName("bics_level_2_industry_group_name");
            entity.Property(e => e.BpipeReferenceSecurityClass)
                .HasMaxLength(45)
                .HasColumnName("bpipe_reference_security_class");
            entity.Property(e => e.Bullet)
                .HasMaxLength(1)
                .HasColumnName("bullet");
            entity.Property(e => e.Callable)
                .HasMaxLength(45)
                .HasColumnName("callable");
            entity.Property(e => e.ClassificationLevel1Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_1_name");
            entity.Property(e => e.ClassificationLevel2Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_2_name");
            entity.Property(e => e.ClassificationLevel3Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_3_name");
            entity.Property(e => e.ClassificationLevel4Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_4_name");
            entity.Property(e => e.CountryIso)
                .HasMaxLength(10)
                .HasColumnName("country_iso");
            entity.Property(e => e.Cpn).HasColumnName("cpn");
            entity.Property(e => e.CpnCap).HasColumnName("cpn_cap");
            entity.Property(e => e.CpnTyp)
                .HasMaxLength(45)
                .HasColumnName("cpn_typ");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.ExchCode)
                .HasMaxLength(45)
                .HasColumnName("exch_code");
            entity.Property(e => e.FundAssetClassFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_asset_class_focus");
            entity.Property(e => e.FundCrncyFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_crncy_focus");
            entity.Property(e => e.FundGeoFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_geo_focus");
            entity.Property(e => e.FundIndustryFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_industry_focus");
            entity.Property(e => e.FundMgmtStyle)
                .HasMaxLength(45)
                .HasColumnName("fund_mgmt_style");
            entity.Property(e => e.FundMktCapFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_mkt_cap_focus");
            entity.Property(e => e.FundRtgClassFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_rtg_class_focus");
            entity.Property(e => e.FundStrategy)
                .HasMaxLength(45)
                .HasColumnName("fund_strategy");
            entity.Property(e => e.GicsIndustry).HasColumnName("gics_industry");
            entity.Property(e => e.GicsIndustryGroup).HasColumnName("gics_industry_group");
            entity.Property(e => e.GicsIndustryGroupName)
                .HasMaxLength(45)
                .HasColumnName("gics_industry_group_name");
            entity.Property(e => e.GicsIndustryName)
                .HasMaxLength(45)
                .HasColumnName("gics_industry_name");
            entity.Property(e => e.GicsSector).HasColumnName("gics_sector");
            entity.Property(e => e.GicsSectorName)
                .HasMaxLength(45)
                .HasColumnName("gics_sector_name");
            entity.Property(e => e.GicsSubIndustry).HasColumnName("gics_sub_industry");
            entity.Property(e => e.GicsSubIndustryName)
                .HasMaxLength(45)
                .HasColumnName("gics_sub_industry_name");
            entity.Property(e => e.HbMaturityBandFocus)
                .HasMaxLength(45)
                .HasColumnName("hb_maturity_band_focus");
            entity.Property(e => e.IsPerpetual)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_perpetual");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Issuer)
                .HasMaxLength(90)
                .HasColumnName("issuer");
            entity.Property(e => e.Listed)
                .HasDefaultValueSql("'1'")
                .HasColumnName("LISTED");
            entity.Property(e => e.Maturity)
                .HasColumnType("datetime")
                .HasColumnName("maturity");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.SecurityTyp)
                .HasMaxLength(45)
                .HasColumnName("security_typ");
        });

        modelBuilder.Entity<DexInstrumentCntryAlloc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_instrument_cntry_alloc");

            entity.HasIndex(e => e.InstrumentId, "INSTRUMENT_ID");

            entity.HasIndex(e => e.AllocDate, "instrumentcntryalloc_allocdate_index");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.GeographicalRegion)
                .HasMaxLength(45)
                .HasColumnName("geographical_region");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.PercentOfFund).HasColumnName("percent_of_fund");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexInstrumentCntryAllocs)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dex_instrument_cntry_alloc_ibfk_1");
        });

        modelBuilder.Entity<DexInstrumentMcapAlloc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_instrument_mcap_alloc");

            entity.HasIndex(e => e.InstrumentId, "INSTRUMENT_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.MarketCapAllocationPercentage).HasColumnName("market_cap_allocation_percentage");
            entity.Property(e => e.MarketCapCategoryName)
                .HasMaxLength(45)
                .HasColumnName("market_cap_category_name");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexInstrumentMcapAllocs)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dex_instrument_mcap_alloc_ibfk_1");
        });

        modelBuilder.Entity<DexInstrumentPrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_instrument_prices");

            entity.HasIndex(e => e.InstrumentId, "instrumentprices_instrumentid_index");

            entity.HasIndex(e => e.PriceDate, "instrumentprices_price_date");

            entity.HasIndex(e => new { e.PriceDate, e.InstrumentId }, "instrumentprices_pricedate_instrumentid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc).HasColumnName("INT_ACC");
            entity.Property(e => e.ModDur).HasColumnName("MOD_DUR");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.PriceDate)
                .HasColumnType("datetime")
                .HasColumnName("PRICE_DATE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexInstrumentPrices)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dex_instrument_prices_ibfk_1");
        });

        modelBuilder.Entity<DexInstrumentSectorAlloc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_instrument_sector_alloc");

            entity.HasIndex(e => e.InstrumentId, "INSTRUMENT_ID");

            entity.HasIndex(e => e.AllocDate, "instrumentsectoralloc_allocdate_index");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.IndustrySectorAllocationPercentage).HasColumnName("industry_sector_allocation_percentage");
            entity.Property(e => e.IndustrySectorName)
                .HasMaxLength(60)
                .HasColumnName("industry_sector_name");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexInstrumentSectorAllocs)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dex_instrument_sector_alloc_ibfk_1");
        });

        modelBuilder.Entity<DexInstrumentsNew>(entity =>
        {
            entity.HasKey(e => e.NewInstrumentId).HasName("PRIMARY");

            entity.ToTable("dex_instruments_new");

            entity.HasIndex(e => e.BbTicker, "instruments_bbticker_index");

            entity.HasIndex(e => e.Isin, "instruments_isin_ticker");

            entity.Property(e => e.NewInstrumentId).HasColumnName("NEW_INSTRUMENT_ID");
            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.BicsLevel1SectorName)
                .HasMaxLength(45)
                .HasColumnName("bics_level_1_sector_name");
            entity.Property(e => e.BicsLevel2IndustryGroupName)
                .HasMaxLength(45)
                .HasColumnName("bics_level_2_industry_group_name");
            entity.Property(e => e.BpipeReferenceSecurityClass)
                .HasMaxLength(45)
                .HasColumnName("bpipe_reference_security_class");
            entity.Property(e => e.Bullet)
                .HasMaxLength(1)
                .HasColumnName("bullet");
            entity.Property(e => e.Callable)
                .HasMaxLength(45)
                .HasColumnName("callable");
            entity.Property(e => e.ClassificationLevel1Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_1_name");
            entity.Property(e => e.ClassificationLevel2Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_2_name");
            entity.Property(e => e.ClassificationLevel3Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_3_name");
            entity.Property(e => e.ClassificationLevel4Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_4_name");
            entity.Property(e => e.CountryIso)
                .HasMaxLength(10)
                .HasColumnName("country_iso");
            entity.Property(e => e.Cpn).HasColumnName("cpn");
            entity.Property(e => e.CpnCap).HasColumnName("cpn_cap");
            entity.Property(e => e.CpnTyp)
                .HasMaxLength(45)
                .HasColumnName("cpn_typ");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.ExchCode)
                .HasMaxLength(45)
                .HasColumnName("exch_code");
            entity.Property(e => e.FundAssetClassFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_asset_class_focus");
            entity.Property(e => e.FundCrncyFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_crncy_focus");
            entity.Property(e => e.FundGeoFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_geo_focus");
            entity.Property(e => e.FundIndustryFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_industry_focus");
            entity.Property(e => e.FundMgmtStyle)
                .HasMaxLength(45)
                .HasColumnName("fund_mgmt_style");
            entity.Property(e => e.FundMktCapFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_mkt_cap_focus");
            entity.Property(e => e.FundRtgClassFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_rtg_class_focus");
            entity.Property(e => e.FundStrategy)
                .HasMaxLength(45)
                .HasColumnName("fund_strategy");
            entity.Property(e => e.GicsIndustry).HasColumnName("gics_industry");
            entity.Property(e => e.GicsIndustryGroup).HasColumnName("gics_industry_group");
            entity.Property(e => e.GicsIndustryGroupName)
                .HasMaxLength(45)
                .HasColumnName("gics_industry_group_name");
            entity.Property(e => e.GicsIndustryName)
                .HasMaxLength(45)
                .HasColumnName("gics_industry_name");
            entity.Property(e => e.GicsSector).HasColumnName("gics_sector");
            entity.Property(e => e.GicsSectorName)
                .HasMaxLength(45)
                .HasColumnName("gics_sector_name");
            entity.Property(e => e.GicsSubIndustry).HasColumnName("gics_sub_industry");
            entity.Property(e => e.GicsSubIndustryName)
                .HasMaxLength(45)
                .HasColumnName("gics_sub_industry_name");
            entity.Property(e => e.HbMaturityBandFocus)
                .HasMaxLength(45)
                .HasColumnName("hb_maturity_band_focus");
            entity.Property(e => e.InputDate)
                .HasColumnType("date")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.IsPerpetual)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_perpetual");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Issuer)
                .HasMaxLength(90)
                .HasColumnName("issuer");
            entity.Property(e => e.Listed)
                .HasDefaultValueSql("'1'")
                .HasColumnName("LISTED");
            entity.Property(e => e.Maturity)
                .HasColumnType("datetime")
                .HasColumnName("maturity");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.SecurityTyp)
                .HasMaxLength(45)
                .HasColumnName("security_typ");
        });

        modelBuilder.Entity<DexInstrumentsSfdr>(entity =>
        {
            entity.HasKey(e => e.InstrumentId).HasName("PRIMARY");

            entity.ToTable("dex_instruments_sfdr");

            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Sfdr).HasColumnName("SFDR");
        });

        modelBuilder.Entity<DexInstrumentsUnlisted>(entity =>
        {
            entity.HasKey(e => e.InstrumentUnlistedId).HasName("PRIMARY");

            entity.ToTable("dex_instruments_unlisted");

            entity.Property(e => e.InstrumentUnlistedId).HasColumnName("INSTRUMENT_UNLISTED_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
        });

        modelBuilder.Entity<DexIntranetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_intranet_users");

            entity.HasIndex(e => e.Email, "fk_users_employees_email_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(45)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(60)
                .HasColumnName("password");
        });

        modelBuilder.Entity<DexManager>(entity =>
        {
            entity.HasKey(e => e.ManagerId).HasName("PRIMARY");

            entity.ToTable("dex_manager");

            entity.Property(e => e.ManagerId).HasColumnName("MANAGER_ID");
            entity.Property(e => e.ManagerName)
                .HasMaxLength(60)
                .HasColumnName("MANAGER_NAME");
        });

        modelBuilder.Entity<DexMgmtPerfFee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_mgmt_perf_fees");

            entity.HasIndex(e => e.AccountId, "fk_mgmtperffees_accountid_idx");

            entity.HasIndex(e => e.IncomeBankId, "fk_mgmtperffees_bank_incomebankid_idx");

            entity.HasIndex(e => e.Currency, "fk_mgmtperffees_currency_currency_idx");

            entity.HasIndex(e => e.FeeTypeId, "fk_mgmtperffees_feetypeid_idx");

            entity.HasIndex(e => e.FeeDate, "mgmtperffees_feedate_index");

            entity.HasIndex(e => e.TransactionId, "transaction_id");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.Comment)
                .HasMaxLength(300)
                .HasColumnName("COMMENT");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.FeeDate)
                .HasColumnType("datetime")
                .HasColumnName("FEE_DATE");
            entity.Property(e => e.FeeGrossVat)
                .HasComment("Provided in negative terms to reflect cash impact on client account")
                .HasColumnName("FEE_GROSS_VAT");
            entity.Property(e => e.FeeNetVat)
                .HasComment("Provided in positive terms, to reflect income for PP")
                .HasColumnName("FEE_NET_VAT");
            entity.Property(e => e.FeeTypeId).HasColumnName("FEE_TYPE_ID");
            entity.Property(e => e.IncomeBankId).HasColumnName("INCOME_BANK_ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.PpTransaction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.PricePp).HasColumnName("PRICE_PP");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");

            entity.HasOne(d => d.Account).WithMany(p => p.DexMgmtPerfFees)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mgmtperffees_accountid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexMgmtPerfFees)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mgmtperffees_currency_currency");

            entity.HasOne(d => d.FeeType).WithMany(p => p.DexMgmtPerfFees)
                .HasForeignKey(d => d.FeeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mgmtperffees_feetypeid");

            entity.HasOne(d => d.IncomeBank).WithMany(p => p.DexMgmtPerfFees)
                .HasForeignKey(d => d.IncomeBankId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mgmtperffees_bank_incomebankid");
        });

        modelBuilder.Entity<DexPartner>(entity =>
        {
            entity.HasKey(e => e.PartnerId).HasName("PRIMARY");

            entity.ToTable("dex_partners");

            entity.Property(e => e.PartnerId).HasColumnName("PARTNER_ID");
            entity.Property(e => e.PartnerName)
                .HasMaxLength(255)
                .HasColumnName("PARTNER_NAME");
            entity.Property(e => e.PartnerType)
                .HasMaxLength(255)
                .HasColumnName("PARTNER_TYPE");
        });

        modelBuilder.Entity<DexPeCommitment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_pe_commitments");

            entity.HasIndex(e => e.DepotId, "fk_pe_depots_depotid");

            entity.HasIndex(e => e.InstrumentId, "fk_pe_instruments_instrumentid");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Commitment).HasColumnName("COMMITMENT");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("EXPIRY_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");

            entity.HasOne(d => d.Depot).WithMany(p => p.DexPeCommitments)
                .HasForeignKey(d => d.DepotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pe_depots_depotid");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexPeCommitments)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pe_instruments_instrumentid");
        });

        modelBuilder.Entity<DexPolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_policy");

            entity.HasIndex(e => e.AccountId, "fk_policy_accountid_idx");

            entity.HasIndex(e => e.Currency, "fk_policy_currency_currency_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.ApplicationId)
                .HasMaxLength(45)
                .HasColumnName("APPLICATION_ID");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.Location)
                .HasMaxLength(45)
                .HasColumnName("LOCATION");
            entity.Property(e => e.PolicyId)
                .HasMaxLength(45)
                .HasColumnName("POLICY_ID");

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.DexPolicies)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policy_accountid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexPolicies)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policy_currency_currency");
        });

        modelBuilder.Entity<DexPpFeeType>(entity =>
        {
            entity.HasKey(e => e.FeeTypeId).HasName("PRIMARY");

            entity.ToTable("dex_pp_fee_types");

            entity.Property(e => e.FeeTypeId).HasColumnName("FEE_TYPE_ID");
            entity.Property(e => e.FeeDescription)
                .HasMaxLength(255)
                .HasColumnName("FEE_DESCRIPTION");
            entity.Property(e => e.FeeType)
                .HasMaxLength(45)
                .HasColumnName("FEE_TYPE");
        });

        modelBuilder.Entity<DexPpFundAssetClassAlloc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_pp_fund_asset_class_alloc");

            entity.HasIndex(e => e.InstrumentId, "INSTRUMENT_ID");

            entity.HasIndex(e => e.AllocDate, "ppfundasasetclassalloc_allocdate_index");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.AssetClassPct).HasColumnName("ASSET_CLASS_PCT");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexPpFundAssetClassAllocs)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dex_pp_fund_asset_class_alloc_ibfk_1");
        });

        modelBuilder.Entity<DexProfileAllocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_profile_allocation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.Balanceret).HasColumnName("BALANCERET");
            entity.Property(e => e.Component)
                .HasMaxLength(45)
                .HasColumnName("COMPONENT");
            entity.Property(e => e.Fx)
                .HasMaxLength(3)
                .HasColumnName("FX");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Konservativ).HasColumnName("KONSERVATIV");
            entity.Property(e => e.Moderat).HasColumnName("MODERAT");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Offensiv).HasColumnName("OFFENSIV");
            entity.Property(e => e.SupplementalCurrency)
                .HasMaxLength(3)
                .HasColumnName("SUPPLEMENTAL_CURRENCY");
            entity.Property(e => e.SupplementalTickers)
                .HasMaxLength(45)
                .HasColumnName("SUPPLEMENTAL_TICKERS");
            entity.Property(e => e.Ticker)
                .HasMaxLength(45)
                .HasColumnName("TICKER");
        });

        modelBuilder.Entity<DexProfileAllocationSe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_profile_allocation_se");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.Balanceret).HasColumnName("BALANCERET");
            entity.Property(e => e.Component)
                .HasMaxLength(45)
                .HasColumnName("COMPONENT");
            entity.Property(e => e.Fx)
                .HasMaxLength(3)
                .HasColumnName("FX");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Konservativ).HasColumnName("KONSERVATIV");
            entity.Property(e => e.Moderat).HasColumnName("MODERAT");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Offensiv).HasColumnName("OFFENSIV");
            entity.Property(e => e.SupplementalCurrency)
                .HasMaxLength(3)
                .HasColumnName("SUPPLEMENTAL_CURRENCY");
            entity.Property(e => e.SupplementalTickers)
                .HasMaxLength(45)
                .HasColumnName("SUPPLEMENTAL_TICKERS");
            entity.Property(e => e.Ticker)
                .HasMaxLength(45)
                .HasColumnName("TICKER");
        });

        modelBuilder.Entity<DexProfileProductAllocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_profile_product_allocation");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClientProfile)
                .HasMaxLength(45)
                .HasColumnName("CLIENT_PROFILE");
            entity.Property(e => e.Product)
                .HasMaxLength(45)
                .HasColumnName("PRODUCT");
            entity.Property(e => e.Target).HasColumnName("TARGET");
        });

        modelBuilder.Entity<DexProgress>(entity =>
        {
            entity.HasKey(e => e.Process).HasName("PRIMARY");

            entity.ToTable("dex_progress");

            entity.Property(e => e.Process).HasColumnName("PROCESS");
            entity.Property(e => e.ErrorMsg)
                .HasMaxLength(2000)
                .HasColumnName("ERROR_MSG");
            entity.Property(e => e.LastRunDate)
                .HasColumnType("date")
                .HasColumnName("LAST_RUN_DATE");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.Step).HasColumnName("STEP");
            entity.Property(e => e.Success).HasColumnName("SUCCESS");
        });

        modelBuilder.Entity<DexReturnDate>(entity =>
        {
            entity.HasKey(e => e.ReturnDate).HasName("PRIMARY");

            entity.ToTable("dex_return_dates");

            entity.Property(e => e.ReturnDate)
                .HasComment("All daily return dates in PP history. Based on dex_dafkast from Access and all prior open days on OMXCSE.")
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
        });

        modelBuilder.Entity<DexReturnGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_return_groups");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GroupName)
                .HasMaxLength(65)
                .HasColumnName("GROUP_NAME");
            entity.Property(e => e.InOutGroup).HasColumnName("IN_OUT_GROUP");
        });

        modelBuilder.Entity<DexSecurityTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PRIMARY");

            entity.ToTable("dex_security_transactions");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.HasIndex(e => e.AccountId, "fk_securitytransactions_accountid_idx");

            entity.HasIndex(e => e.Currency, "fk_securitytransactions_currency_currency_idx");

            entity.HasIndex(e => e.InstrumentId, "securitytransactions_instrumentid");

            entity.HasIndex(e => e.TradeDate, "securitytransactions_tradedate_index");

            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Counterpart).HasColumnName("COUNTERPART");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.DuplicateCount)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DUPLICATE_COUNT");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.PpTransaction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.Reverse).HasColumnName("REVERSE");
            entity.Property(e => e.TickerConflictIsin)
                .HasMaxLength(45)
                .HasColumnName("TICKER_CONFLICT_ISIN");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");

            entity.HasOne(d => d.Account).WithMany(p => p.DexSecurityTransactions)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_securitytransactions_clientaccount_accountid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexSecurityTransactions)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_securitytransactions_currency_currency");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexSecurityTransactions)
                .HasForeignKey(d => d.InstrumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_securitytransactions_instruments_instrumentid");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexSecurityTransactions)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_securitytransactions_tradetypeid_tradetypeid");
        });

        modelBuilder.Entity<DexStagingBondCoupon>(entity =>
        {
            entity.HasKey(e => e.StagingTransactionId).HasName("PRIMARY");

            entity.ToTable("dex_staging_bond_coupons");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.HasIndex(e => e.AccountId, "fk_stagingbondcoupons_accountid_idx");

            entity.HasIndex(e => e.Currency, "fk_stagingbondcoupons_currency_currency");

            entity.HasIndex(e => e.InstrumentId, "stagingbondcoupons_instrument_id");

            entity.HasIndex(e => e.TradeDate, "stagingbondcoupons_tradedate_index");

            entity.Property(e => e.StagingTransactionId).HasColumnName("STAGING_TRANSACTION_ID");
            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Currency).HasColumnName("CURRENCY");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.PpTransaction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.Processed).HasColumnName("PROCESSED");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TradeTypeName)
                .HasMaxLength(255)
                .HasColumnName("TRADE_TYPE_NAME");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.DexStagingBondCoupons)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("fk_stagingbondcoupons_accountid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexStagingBondCoupons)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_stagingbondcoupons_currency_currency");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexStagingBondCoupons)
                .HasForeignKey(d => d.InstrumentId)
                .HasConstraintName("fk_stagingbondcoupons_instruments_instrumentid");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexStagingBondCoupons)
                .HasForeignKey(d => d.TradeTypeId)
                .HasConstraintName("fk_stagingbondcoupons_tradetypeid_tradetypeid");
        });

        modelBuilder.Entity<DexStagingCashTransaction>(entity =>
        {
            entity.HasKey(e => e.StagingTransactionId).HasName("PRIMARY");

            entity.ToTable("dex_staging_cash_transactions");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.HasIndex(e => e.Currency, "fk_stagingcashtransaction_currency_currency");

            entity.HasIndex(e => e.AccountId, "fk_stagingcashtransactions_accountid_idx");

            entity.HasIndex(e => e.TradeDate, "stagingcashtransactions_tradedate_index");

            entity.Property(e => e.StagingTransactionId).HasColumnName("STAGING_TRANSACTION_ID");
            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("COMMENT");
            entity.Property(e => e.Currency).HasColumnName("CURRENCY");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.PpTransaction).HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.Processed).HasColumnName("PROCESSED");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TradeTypeName)
                .HasMaxLength(255)
                .HasColumnName("TRADE_TYPE_NAME");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.DexStagingCashTransactions)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("fk_stagingcashtransactions_accountid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexStagingCashTransactions)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_stagingcashtransaction_currency_currency");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexStagingCashTransactions)
                .HasForeignKey(d => d.TradeTypeId)
                .HasConstraintName("fk_stagingcashtransaction_tradetypeid_tradetypeid");
        });

        modelBuilder.Entity<DexStagingCost>(entity =>
        {
            entity.HasKey(e => e.StagingId).HasName("PRIMARY");

            entity.ToTable("dex_staging_costs");

            entity.HasIndex(e => e.StagingTransactionId, "STAGING_TRANSACTION_ID");

            entity.HasIndex(e => e.AccountId, "fk_stagingcosts_accountid_idx");

            entity.HasIndex(e => e.BankCostId, "fk_stagingcosts_bankcostid_idx");

            entity.HasIndex(e => e.Currency, "fk_stagingcosts_currency_currency_idx");

            entity.HasIndex(e => e.TradeTypeId, "fk_stagingcosts_tradetypeid_idx");

            entity.HasIndex(e => e.TradeDate, "stagingcosts_tradedate_index");

            entity.Property(e => e.StagingId).HasColumnName("STAGING_ID");
            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.BankCostId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("BANK_COST_ID");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.DexTableId).HasColumnName("DEX_TABLE_ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.PpTransaction).HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.Processed).HasColumnName("PROCESSED");
            entity.Property(e => e.StagingTableRef)
                .HasMaxLength(45)
                .HasColumnName("STAGING_TABLE_REF");
            entity.Property(e => e.StagingTransactionId).HasColumnName("STAGING_TRANSACTION_ID");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId)
                .HasDefaultValueSql("'8'")
                .HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TradeTypeName)
                .HasMaxLength(45)
                .HasColumnName("TRADE_TYPE_NAME");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.DexStagingCosts)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("fk_stagingcosts_accountid");

            entity.HasOne(d => d.BankCost).WithMany(p => p.DexStagingCosts)
                .HasForeignKey(d => d.BankCostId)
                .HasConstraintName("fk_stagingcosts_bankcostid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexStagingCosts)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_stagingcosts_currency_currency");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexStagingCosts)
                .HasForeignKey(d => d.TradeTypeId)
                .HasConstraintName("fk_stagingcosts_tradetypeid");
        });

        modelBuilder.Entity<DexStagingDividendTransaction>(entity =>
        {
            entity.HasKey(e => e.StagingTransactionId).HasName("PRIMARY");

            entity.ToTable("dex_staging_dividend_transactions");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.HasIndex(e => e.AccountId, "fk_stagingdividendtransactions_accountid_idx");

            entity.HasIndex(e => e.Currency, "fk_stagingdividendtransactions_currency_currency_idx");

            entity.HasIndex(e => e.InstrumentId, "fk_stagingdividendtransactions_instrumentid");

            entity.HasIndex(e => e.TradeDate, "stagingdividendtransactions_tradedate_index");

            entity.Property(e => e.StagingTransactionId).HasColumnName("STAGING_TRANSACTION_ID");
            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.CashImpact)
                .HasDefaultValueSql("'1'")
                .HasColumnName("CASH_IMPACT");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Currency).HasColumnName("CURRENCY");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.PpTransaction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.Processed).HasColumnName("PROCESSED");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TradeTypeName)
                .HasMaxLength(255)
                .HasColumnName("TRADE_TYPE_NAME");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.DexStagingDividendTransactions)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("fk_stagingdividendtransactions_accountid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexStagingDividendTransactions)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_stagingdividendtransactions_currency_currency");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexStagingDividendTransactions)
                .HasForeignKey(d => d.InstrumentId)
                .HasConstraintName("fk_stagingdividendtransactions_instrumentid");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexStagingDividendTransactions)
                .HasForeignKey(d => d.TradeTypeId)
                .HasConstraintName("fk_stagingdividendtransactions_tradetypeid");
        });

        modelBuilder.Entity<DexStagingSecurityTransaction>(entity =>
        {
            entity.HasKey(e => e.StagingTransactionId).HasName("PRIMARY");

            entity.ToTable("dex_staging_security_transactions");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.HasIndex(e => e.Currency, "fk_stagingsecuritytransactions_currency_currency_idx");

            entity.HasIndex(e => e.AccountId, "fk_staginsgecuritytransactions_accountid_idx");

            entity.HasIndex(e => e.InstrumentId, "stagingsecuritytransactions_instrumentid");

            entity.HasIndex(e => e.TradeDate, "stagingsecuritytransactions_tradedate_index");

            entity.Property(e => e.StagingTransactionId).HasColumnName("STAGING_TRANSACTION_ID");
            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Counterpart).HasColumnName("COUNTERPART");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.DuplicateCount)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DUPLICATE_COUNT");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.PpTransaction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Processed).HasColumnName("PROCESSED");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.Reverse).HasColumnName("REVERSE");
            entity.Property(e => e.TickerConflictIsin)
                .HasMaxLength(45)
                .HasColumnName("TICKER_CONFLICT_ISIN");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TradeTypeName)
                .HasMaxLength(255)
                .HasColumnName("TRADE_TYPE_NAME");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.DexStagingSecurityTransactions)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("fk_staingsecuritytransactions_clientaccount_accountid");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.DexStagingSecurityTransactions)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_stagingsecuritytransactions_currency_currency");

            entity.HasOne(d => d.Instrument).WithMany(p => p.DexStagingSecurityTransactions)
                .HasForeignKey(d => d.InstrumentId)
                .HasConstraintName("fk_stagingsecuritytransactions_instruments_instrumentid");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexStagingSecurityTransactions)
                .HasForeignKey(d => d.TradeTypeId)
                .HasConstraintName("fk_stagingsecuritytransactions_tradetypeid_tradetypeid");
        });

        modelBuilder.Entity<DexTodaysTransaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_todays_transactions");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccCurrency)
                .HasMaxLength(3)
                .HasColumnName("ACC_CURRENCY");
            entity.Property(e => e.AccExrate).HasColumnName("ACC_EXRATE");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.AmountAccCur).HasColumnName("AMOUNT_ACC_CUR");
            entity.Property(e => e.BankCostId).HasColumnName("BANK_COST_ID");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.CostId).HasColumnName("COST_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DexTableName)
                .HasMaxLength(45)
                .HasColumnName("DEX_TABLE_NAME");
            entity.Property(e => e.ExRate).HasColumnName("EX_RATE");
            entity.Property(e => e.FeeTypeId).HasColumnName("FEE_TYPE_ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("date")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.OpeExrate).HasColumnName("OPE_EXRATE");
            entity.Property(e => e.PpTransaction).HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.Reverse).HasColumnName("REVERSE");
            entity.Property(e => e.TradeDate)
                .HasColumnType("date")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("date")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<DexTradeTypeBil>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_trade_type_bil");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountFactor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("AMOUNT_FACTOR");
            entity.Property(e => e.BankTypeName)
                .HasMaxLength(255)
                .HasColumnName("BANK_TYPE_NAME");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.CostsFactor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("COSTS_FACTOR");
            entity.Property(e => e.GrossFactor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("GROSS_FACTOR");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.QuantityFactor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("QUANTITY_FACTOR");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexTradeTypeBils)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dex_trade_type_bil_ibfk_1");
        });

        modelBuilder.Entity<DexTradeTypeEfg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_trade_type_efg");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountFactor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("AMOUNT_FACTOR");
            entity.Property(e => e.BankTypeName)
                .HasMaxLength(255)
                .HasColumnName("BANK_TYPE_NAME");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.CostsFactor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("COSTS_FACTOR");
            entity.Property(e => e.GrossFactor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("GROSS_FACTOR");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.QuantityFactor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("QUANTITY_FACTOR");
            entity.Property(e => e.TradeTypeId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("TRADE_TYPE_ID");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexTradeTypeEfgs)
                .HasForeignKey(d => d.TradeTypeId)
                .HasConstraintName("dex_trade_type_efg_ibfk_1");
        });

        modelBuilder.Entity<DexTradeTypeId>(entity =>
        {
            entity.HasKey(e => e.TradeTypeId).HasName("PRIMARY");

            entity.ToTable("dex_trade_type_id");

            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.DexTableId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DEX_TABLE_ID");
            entity.Property(e => e.TradeTypeName)
                .HasMaxLength(255)
                .HasColumnName("TRADE_TYPE_NAME");
            entity.Property(e => e.TradeTypeNameDa)
                .HasMaxLength(255)
                .HasColumnName("TRADE_TYPE_NAME_DA");
        });

        modelBuilder.Entity<DexTradeTypeJyske>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_trade_type_jyske");

            entity.HasIndex(e => e.BankTypeName, "BANK_TYPE_NAME");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountFactor).HasColumnName("AMOUNT_FACTOR");
            entity.Property(e => e.BankTypeName).HasColumnName("BANK_TYPE_NAME");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.QuantityFactor).HasColumnName("QUANTITY_FACTOR");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexTradeTypeJyskes)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dex_trade_type_jyske_ibfk_1");
        });

        modelBuilder.Entity<DexTradeTypeNew>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_trade_type_new");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountFactor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("AMOUNT_FACTOR");
            entity.Property(e => e.BankTypeName)
                .HasMaxLength(255)
                .HasColumnName("BANK_TYPE_NAME");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.CostsFactor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("COSTS_FACTOR");
            entity.Property(e => e.GrossFactor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("GROSS_FACTOR");
            entity.Property(e => e.InputDate)
                .HasColumnType("date")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.IsinExists).HasColumnName("ISIN_EXISTS");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.QuantityFactor)
                .HasDefaultValueSql("'0'")
                .HasColumnName("QUANTITY_FACTOR");
            entity.Property(e => e.RefTable)
                .HasMaxLength(50)
                .HasColumnName("REF_TABLE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexTradeTypeNews)
                .HasForeignKey(d => d.TradeTypeId)
                .HasConstraintName("dex_trade_type_new_ibfk_1");
        });

        modelBuilder.Entity<DexTradeTypeNordnet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_trade_type_nordnet");

            entity.HasIndex(e => e.BankTypeName, "BANK_TYPE_NAME");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountFactor).HasColumnName("AMOUNT_FACTOR");
            entity.Property(e => e.BankTypeName).HasColumnName("BANK_TYPE_NAME");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.IsinExists).HasColumnName("ISIN_EXISTS");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.QuantityFactor).HasColumnName("QUANTITY_FACTOR");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexTradeTypeNordnets)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tradetypenordnet_tradetypeid");
        });

        modelBuilder.Entity<DexTradeTypeNordnetSe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_trade_type_nordnet_se");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountFactor).HasColumnName("AMOUNT_FACTOR");
            entity.Property(e => e.BankTypeName)
                .HasMaxLength(45)
                .HasColumnName("BANK_TYPE_NAME");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.QuantityFactor).HasColumnName("QUANTITY_FACTOR");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
        });

        modelBuilder.Entity<DexTradeTypeRilba>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_trade_type_rilba");

            entity.HasIndex(e => e.TradeTypeId, "fk_tradetyperilba_tradetypeid_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountFactor).HasColumnName("AMOUNT_FACTOR");
            entity.Property(e => e.BankTypeName)
                .HasMaxLength(80)
                .HasColumnName("BANK_TYPE_NAME");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.QuantityFactor).HasColumnName("QUANTITY_FACTOR");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexTradeTypeRilbas)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tradetyperilba_tradetypeid");
        });

        modelBuilder.Entity<DexTradeTypeSaxo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_trade_type_saxo");

            entity.HasIndex(e => e.BankTypeName, "BANK_TYPE_NAME");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountFactor).HasColumnName("AMOUNT_FACTOR");
            entity.Property(e => e.BankTypeName).HasColumnName("BANK_TYPE_NAME");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.CostsFactor).HasColumnName("COSTS_FACTOR");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexTradeTypeSaxos)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tradetypesaxo_tradetypeid");
        });

        modelBuilder.Entity<DexTradeTypeSparnord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_trade_type_sparnord");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountFactor).HasColumnName("AMOUNT_FACTOR");
            entity.Property(e => e.BankTypeName)
                .HasMaxLength(255)
                .HasColumnName("BANK_TYPE_NAME");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.QuantityFactor).HasColumnName("QUANTITY_FACTOR");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexTradeTypeSparnords)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TRADE_TYPE_ID");
        });

        modelBuilder.Entity<DexTradeTypeVp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dex_trade_type_vp");

            entity.HasIndex(e => e.TradeTypeId, "TRADE_TYPE_ID_idx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountFactor).HasColumnName("AMOUNT_FACTOR");
            entity.Property(e => e.BankTypeName)
                .HasMaxLength(255)
                .HasColumnName("BANK_TYPE_NAME");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.QuantityFactor).HasColumnName("QUANTITY_FACTOR");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");

            entity.HasOne(d => d.TradeType).WithMany(p => p.DexTradeTypeVps)
                .HasForeignKey(d => d.TradeTypeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("tradetype_vp");
        });

        modelBuilder.Entity<DexTransactionTable>(entity =>
        {
            entity.HasKey(e => e.DexTableId).HasName("PRIMARY");

            entity.ToTable("dex_transaction_tables");

            entity.Property(e => e.DexTableId).HasColumnName("DEX_TABLE_ID");
            entity.Property(e => e.DexTableName)
                .HasMaxLength(255)
                .HasColumnName("DEX_TABLE_NAME");
        });

        modelBuilder.Entity<DividendTransactionsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("dividend_transactions_view");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.CashImpact)
                .HasDefaultValueSql("'1'")
                .HasColumnName("CASH_IMPACT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.PpTransaction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<EomClientReturnOverviewRepCur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("eom_client_return_overview_rep_cur");

            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.DkkReturnActual).HasColumnName("DKK_RETURN_ACTUAL");
            entity.Property(e => e.GrossBmReturnRepCur).HasColumnName("GROSS_BM_RETURN_REP_CUR");
            entity.Property(e => e.GrossPortfolioReturnRepCur).HasColumnName("GROSS_PORTFOLIO_RETURN_REP_CUR");
            entity.Property(e => e.RepCurReturn).HasColumnName("REP_CUR_RETURN");
            entity.Property(e => e.ReturnDate)
                .HasComment("All daily return dates in PP history. Based on dex_dafkast from Access and all prior open days on OMXCSE.")
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
        });

        modelBuilder.Entity<EomDepotReturnOverviewRepCur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("eom_depot_return_overview_rep_cur");

            entity.Property(e => e.DepotId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DEPOT_ID");
            entity.Property(e => e.GrossDepotReturnRepCur).HasColumnName("GROSS_DEPOT_RETURN_REP_CUR");
            entity.Property(e => e.GrossPortfolioAttrReturn).HasColumnName("GROSS_PORTFOLIO_ATTR_RETURN");
            entity.Property(e => e.RepCurReturnActual).HasColumnName("REP_CUR_RETURN_ACTUAL");
            entity.Property(e => e.ReturnDate)
                .HasComment("All daily return dates in PP history. Based on dex_dafkast from Access and all prior open days on OMXCSE.")
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
        });

        modelBuilder.Entity<EomReturnDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("eom_return_dates");

            entity.Property(e => e.ReturnDate)
                .HasComment("All daily return dates in PP history. Based on dex_dafkast from Access and all prior open days on OMXCSE.")
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
        });

        modelBuilder.Entity<FundHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fund_holdings");

            entity.Property(e => e.BbTicker)
                .HasColumnType("text")
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.SecurityName)
                .HasColumnType("text")
                .HasColumnName("security_name");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
        });

        modelBuilder.Entity<FundReturn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("fund_returns");

            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.InstReturn).HasColumnName("INST_RETURN");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.PriceDate)
                .HasColumnType("datetime")
                .HasColumnName("PRICE_DATE");
        });

        modelBuilder.Entity<FxToday>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("fx_today");

            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.ExRate).HasColumnName("EX_RATE");
            entity.Property(e => e.ExRateDate)
                .HasColumnType("datetime")
                .HasColumnName("EX_RATE_DATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
        });

        modelBuilder.Entity<HoldingsListedUnlisted>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("holdings_listed_unlisted");

            entity.Property(e => e.Assets)
                .HasMaxLength(45)
                .HasColumnName("ASSETS");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.ExRate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("EX_RATE");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("INT_ACC");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.ModDur)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MOD_DUR");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
        });

        modelBuilder.Entity<HoldingsPpfundsEom>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("holdings_ppfunds_eom");

            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.ExRate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("EX_RATE");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("INT_ACC");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.ModDur)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MOD_DUR");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
        });

        modelBuilder.Entity<IncomeBankIdView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("income_bank_id_view");

            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.CountryName)
                .HasMaxLength(45)
                .HasColumnName("COUNTRY_NAME");
            entity.Property(e => e.Ec)
                .HasMaxLength(255)
                .HasColumnName("EC");
            entity.Property(e => e.JbCode)
                .HasMaxLength(255)
                .HasColumnName("JB_CODE");
        });

        modelBuilder.Entity<IncomeOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("income_overview");

            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.FeeDate)
                .HasColumnType("datetime")
                .HasColumnName("FEE_DATE");
            entity.Property(e => e.FeeNetVat).HasColumnName("FEE_NET_VAT");
            entity.Property(e => e.FeeTypeId).HasColumnName("FEE_TYPE_ID");
            entity.Property(e => e.Hurdle).HasColumnName("HURDLE");
            entity.Property(e => e.IncomeBankId).HasColumnName("INCOME_BANK_ID");
            entity.Property(e => e.MgmtFee).HasColumnName("MGMT_FEE");
            entity.Property(e => e.PerfFee).HasColumnName("PERF_FEE");
            entity.Property(e => e.RiskProfile)
                .HasMaxLength(45)
                .HasColumnName("RISK_PROFILE");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<IndtjeningPerCappedKunde>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("indtjening_per_capped_kunde");

            entity.Property(e => e.AftaltFeeCapPct).HasColumnName("AFTALT_FEE_CAP_PCT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.FeePctAum).HasColumnName("FEE_PCT_AUM");
            entity.Property(e => e.IndtjeningSoFar).HasColumnName("INDTJENING_SO_FAR");
            entity.Property(e => e.LatestAum).HasColumnName("LATEST_AUM");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<InstrumentBeholdningsoversigtRepCur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("instrument_beholdningsoversigt_rep_cur");

            entity.Property(e => e.AktivType)
                .HasMaxLength(45)
                .HasColumnName("AKTIV_TYPE");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.IntAcc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("INT_ACC");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.ModDur)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MOD_DUR");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.ValueReportingCurrency).HasColumnName("VALUE_REPORTING_CURRENCY");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<InstrumentHoldingsOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("instrument_holdings_overview");

            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.ExRate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("EX_RATE");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("INT_ACC");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.ModDur)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MOD_DUR");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
        });

        modelBuilder.Entity<InstrumentHoldingsReportingValuation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("instrument_holdings_reporting_valuation");

            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.BpipeReferenceSecurityClass)
                .HasMaxLength(45)
                .HasColumnName("bpipe_reference_security_class");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotType)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("INT_ACC");
            entity.Property(e => e.InterestAccRepCur).HasColumnName("INTEREST_ACC_REP_CUR");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.ModDur)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MOD_DUR");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.ValueLoc).HasColumnName("VALUE_LOC");
            entity.Property(e => e.ValueReportingCurrency).HasColumnName("VALUE_REPORTING_CURRENCY");
        });

        modelBuilder.Entity<InstrumentHoldingsVallerod>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("instrument_holdings_vallerod");

            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.BpipeReferenceSecurityClass)
                .HasMaxLength(45)
                .HasColumnName("bpipe_reference_security_class");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotType)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("INT_ACC");
            entity.Property(e => e.InterestAccRepCur).HasColumnName("INTEREST_ACC_REP_CUR");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.ModDur)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MOD_DUR");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.ValueLoc).HasColumnName("VALUE_LOC");
            entity.Property(e => e.ValueReportingCurrency).HasColumnName("VALUE_REPORTING_CURRENCY");
        });

        modelBuilder.Entity<InstrumentPricesWithTickersAndIsin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("instrument_prices_with_tickers_and_isin");

            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc).HasColumnName("INT_ACC");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.ModDur).HasColumnName("MOD_DUR");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.PriceDate)
                .HasColumnType("datetime")
                .HasColumnName("PRICE_DATE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
        });

        modelBuilder.Entity<InstrumentPricesWithTickersAndIsinToday>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("instrument_prices_with_tickers_and_isin_today");

            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc).HasColumnName("INT_ACC");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.ModDur).HasColumnName("MOD_DUR");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.PriceDate)
                .HasColumnType("datetime")
                .HasColumnName("PRICE_DATE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
        });

        modelBuilder.Entity<InstrumentsComparisonExtended>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("instruments_comparison_extended");
        });

        modelBuilder.Entity<InstrumentsSfdr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("instruments_sfdr");

            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.Sfdr).HasColumnName("SFDR");
        });

        modelBuilder.Entity<InstrumentsWithAssetClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("instruments_with_asset_class");

            entity.Property(e => e.Active)
                .HasDefaultValueSql("'1'")
                .HasColumnName("ACTIVE");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.BicsLevel1SectorName)
                .HasMaxLength(45)
                .HasColumnName("bics_level_1_sector_name");
            entity.Property(e => e.BicsLevel2IndustryGroupName)
                .HasMaxLength(45)
                .HasColumnName("bics_level_2_industry_group_name");
            entity.Property(e => e.BpipeReferenceSecurityClass)
                .HasMaxLength(45)
                .HasColumnName("bpipe_reference_security_class");
            entity.Property(e => e.Bullet)
                .HasMaxLength(1)
                .HasColumnName("bullet");
            entity.Property(e => e.Callable)
                .HasMaxLength(45)
                .HasColumnName("callable");
            entity.Property(e => e.ClassificationLevel1Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_1_name");
            entity.Property(e => e.ClassificationLevel2Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_2_name");
            entity.Property(e => e.ClassificationLevel3Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_3_name");
            entity.Property(e => e.ClassificationLevel4Name)
                .HasMaxLength(45)
                .HasColumnName("classification_level_4_name");
            entity.Property(e => e.CountryIso)
                .HasMaxLength(10)
                .HasColumnName("country_iso");
            entity.Property(e => e.Cpn).HasColumnName("cpn");
            entity.Property(e => e.CpnCap).HasColumnName("cpn_cap");
            entity.Property(e => e.CpnTyp)
                .HasMaxLength(45)
                .HasColumnName("cpn_typ");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.ExchCode)
                .HasMaxLength(45)
                .HasColumnName("exch_code");
            entity.Property(e => e.FundAssetClassFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_asset_class_focus");
            entity.Property(e => e.FundCrncyFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_crncy_focus");
            entity.Property(e => e.FundGeoFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_geo_focus");
            entity.Property(e => e.FundIndustryFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_industry_focus");
            entity.Property(e => e.FundMgmtStyle)
                .HasMaxLength(45)
                .HasColumnName("fund_mgmt_style");
            entity.Property(e => e.FundMktCapFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_mkt_cap_focus");
            entity.Property(e => e.FundRtgClassFocus)
                .HasMaxLength(45)
                .HasColumnName("fund_rtg_class_focus");
            entity.Property(e => e.FundStrategy)
                .HasMaxLength(45)
                .HasColumnName("fund_strategy");
            entity.Property(e => e.GicsIndustry).HasColumnName("gics_industry");
            entity.Property(e => e.GicsIndustryGroup).HasColumnName("gics_industry_group");
            entity.Property(e => e.GicsIndustryGroupName)
                .HasMaxLength(45)
                .HasColumnName("gics_industry_group_name");
            entity.Property(e => e.GicsIndustryName)
                .HasMaxLength(45)
                .HasColumnName("gics_industry_name");
            entity.Property(e => e.GicsSector).HasColumnName("gics_sector");
            entity.Property(e => e.GicsSectorName)
                .HasMaxLength(45)
                .HasColumnName("gics_sector_name");
            entity.Property(e => e.GicsSubIndustry).HasColumnName("gics_sub_industry");
            entity.Property(e => e.GicsSubIndustryName)
                .HasMaxLength(45)
                .HasColumnName("gics_sub_industry_name");
            entity.Property(e => e.HbMaturityBandFocus)
                .HasMaxLength(45)
                .HasColumnName("hb_maturity_band_focus");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IsPerpetual)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_perpetual");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Issuer)
                .HasMaxLength(90)
                .HasColumnName("issuer");
            entity.Property(e => e.Maturity)
                .HasColumnType("datetime")
                .HasColumnName("maturity");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.SecurityTyp)
                .HasMaxLength(45)
                .HasColumnName("security_typ");
        });

        modelBuilder.Entity<IntranetAssetClassAlloc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_asset_class_alloc");

            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.AssetClassPct).HasColumnName("ASSET_CLASS_PCT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
        });

        modelBuilder.Entity<IntranetAssetClassLimitsLatest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_asset_class_limits_latest");

            entity.Property(e => e.AllocDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.AssetClassPct).HasColumnName("ASSET_CLASS_PCT");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.MaxLimit).HasColumnName("MAX_LIMIT");
            entity.Property(e => e.MinLimit).HasColumnName("MIN_LIMIT");
        });

        modelBuilder.Entity<IntranetAssetClassLimitsLatestBreach>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_asset_class_limits_latest_breaches");

            entity.Property(e => e.AllocDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.AssetClassPct).HasColumnName("ASSET_CLASS_PCT");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.MaxLimit).HasColumnName("MAX_LIMIT");
            entity.Property(e => e.MinLimit).HasColumnName("MIN_LIMIT");
        });

        modelBuilder.Entity<IntranetAumBankDistribution>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_aum_bank_distribution");

            entity.Property(e => e.AlmBolig).HasColumnName("Alm. Bolig");
            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.Clients).HasColumnName("CLIENTS");
            entity.Property(e => e.TotalAum).HasColumnName("Total AUM");
        });

        modelBuilder.Entity<IntranetAumDashboard>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_aum_dashboard");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.AumDkk).HasColumnName("AUM_DKK");
            entity.Property(e => e.ClientType)
                .HasMaxLength(53)
                .HasColumnName("CLIENT_TYPE");
            entity.Property(e => e.InOutDkk).HasColumnName("IN_OUT_DKK");
        });

        modelBuilder.Entity<IntranetCashExposureCheck>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_cash_exposure_check");

            entity.Property(e => e.CashAgg).HasColumnName("CASH_AGG");
            entity.Property(e => e.CashAmountDkk).HasColumnName("CASH_AMOUNT_DKK");
            entity.Property(e => e.CashPct).HasColumnName("CASH_PCT");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.TotalAumDkk).HasColumnName("TOTAL_AUM_DKK");
        });

        modelBuilder.Entity<IntranetCashOverdraftCheck>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_cash_overdraft_check");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AmountAccCur).HasColumnName("AMOUNT_ACC_CUR");
            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.Iban)
                .HasMaxLength(40)
                .HasColumnName("IBAN");
        });

        modelBuilder.Entity<IntranetClientAccountOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_client_account_overview");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.DepotTypeId).HasColumnName("DEPOT_TYPE_ID");
            entity.Property(e => e.Iban)
                .HasMaxLength(40)
                .HasColumnName("IBAN");
        });

        modelBuilder.Entity<IntranetClientAumDepot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_client_aum_depot");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.CashRepCur).HasColumnName("CASH_REP_CUR");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.InOutRepCur).HasColumnName("IN_OUT_REP_CUR");
            entity.Property(e => e.InstRepCur).HasColumnName("INST_REP_CUR");
            entity.Property(e => e.TotalAumRepCur).HasColumnName("TOTAL_AUM_REP_CUR");
        });

        modelBuilder.Entity<IntranetClientAumId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_client_aum_id");

            entity.Property(e => e.AumDate)
                .HasColumnType("datetime")
                .HasColumnName("AUM_DATE");
            entity.Property(e => e.CashRepCur).HasColumnName("CASH_REP_CUR");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.InOutRepCur).HasColumnName("IN_OUT_REP_CUR");
            entity.Property(e => e.InstRepCur).HasColumnName("INST_REP_CUR");
            entity.Property(e => e.TotalAumRepCur).HasColumnName("TOTAL_AUM_REP_CUR");
        });

        modelBuilder.Entity<IntranetClientBenchmark>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_client_benchmark");

            entity.Property(e => e.BmId).HasColumnName("BM_ID");
            entity.Property(e => e.BmName)
                .HasMaxLength(255)
                .HasColumnName("BM_NAME");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("END_DATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("START_DATE");
        });

        modelBuilder.Entity<IntranetClientOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_client_overview");

            entity.Property(e => e.Aktiv)
                .HasMaxLength(7)
                .HasDefaultValueSql("''")
                .HasColumnName("AKTIV");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.ClientType)
                .HasMaxLength(45)
                .HasColumnName("CLIENT_TYPE");
            entity.Property(e => e.ContractType)
                .HasMaxLength(45)
                .HasColumnName("CONTRACT_TYPE");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasColumnName("COUNTRY");
        });

        modelBuilder.Entity<IntranetClientReturnsId>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_client_returns_id");

            entity.Property(e => e.AumDkkT1).HasColumnName("AUM_DKK_T1");
            entity.Property(e => e.AumRepCur).HasColumnName("AUM_REP_CUR");
            entity.Property(e => e.BmId).HasColumnName("BM_ID");
            entity.Property(e => e.CashRepCur).HasColumnName("CASH_REP_CUR");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.DkkReturnActual).HasColumnName("DKK_RETURN_ACTUAL");
            entity.Property(e => e.ExRate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("EX_RATE");
            entity.Property(e => e.ExRatePrev).HasColumnName("EX_RATE_PREV");
            entity.Property(e => e.FxEffectRepCur).HasColumnName("FX_EFFECT_REP_CUR");
            entity.Property(e => e.FxRet).HasColumnName("FX_RET");
            entity.Property(e => e.GrossBmReturnRepCur).HasColumnName("GROSS_BM_RETURN_REP_CUR");
            entity.Property(e => e.GrossExRateReturn).HasColumnName("GROSS_EX_RATE_RETURN");
            entity.Property(e => e.GrossPortfolioReturnRepCur).HasColumnName("GROSS_PORTFOLIO_RETURN_REP_CUR");
            entity.Property(e => e.InstRepCur).HasColumnName("INST_REP_CUR");
            entity.Property(e => e.IoRepCur).HasColumnName("IO_REP_CUR");
            entity.Property(e => e.RepCurReturn).HasColumnName("REP_CUR_RETURN");
            entity.Property(e => e.RepCurReturnExFx).HasColumnName("REP_CUR_RETURN_EX_FX");
            entity.Property(e => e.ReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
        });

        modelBuilder.Entity<IntranetCurrencyExposure>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_currency_exposure");

            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<IntranetDeposit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_deposits");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.Iban)
                .HasMaxLength(40)
                .HasColumnName("IBAN");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
        });

        modelBuilder.Entity<IntranetIncomeOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_income_overview");

            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.ClientType)
                .HasMaxLength(45)
                .HasColumnName("CLIENT_TYPE");
            entity.Property(e => e.ContractType)
                .HasMaxLength(45)
                .HasColumnName("CONTRACT_TYPE");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.FeeDate)
                .HasColumnType("datetime")
                .HasColumnName("FEE_DATE");
            entity.Property(e => e.FeeDkk).HasColumnName("FEE_DKK");
            entity.Property(e => e.FeeType)
                .HasMaxLength(45)
                .HasColumnName("FEE_TYPE");
            entity.Property(e => e.ManagerName)
                .HasMaxLength(60)
                .HasColumnName("MANAGER_NAME");
            entity.Property(e => e.Month).HasColumnName("MONTH");
            entity.Property(e => e.Quarter).HasColumnName("QUARTER");
            entity.Property(e => e.RiskProfile)
                .HasMaxLength(45)
                .HasColumnName("RISK_PROFILE");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
            entity.Property(e => e.Year).HasColumnName("YEAR");
        });

        modelBuilder.Entity<IntranetLatestCountryAlloc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_latest_country_alloc");

            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Country)
                .HasMaxLength(45)
                .HasColumnName("COUNTRY");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<IntranetLatestSectorAlloc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_latest_sector_alloc");

            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Sector)
                .HasMaxLength(60)
                .HasDefaultValueSql("''")
                .HasColumnName("SECTOR");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<IntranetPeOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_pe_overview");

            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Commitment).HasColumnName("COMMITMENT");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Remaining).HasColumnName("REMAINING");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.TrukketCommitmentCur).HasColumnName("TRUKKET_COMMITMENT_CUR");
            entity.Property(e => e.ValueCommitmentCur).HasColumnName("VALUE_COMMITMENT_CUR");
        });

        modelBuilder.Entity<IntranetPolicyCashCheck>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("intranet_policy_cash_check");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AumAccCur).HasColumnName("AUM_ACC_CUR");
            entity.Property(e => e.CashAccCur).HasColumnName("CASH_ACC_CUR");
            entity.Property(e => e.CashPct).HasColumnName("CASH_PCT");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.Iban)
                .HasMaxLength(40)
                .HasColumnName("IBAN");
            entity.Property(e => e.Location)
                .HasMaxLength(45)
                .HasColumnName("LOCATION");
        });

        modelBuilder.Entity<KursAvanceOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("kurs_avance_overview");

            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.FeeDate)
                .HasColumnType("datetime")
                .HasColumnName("FEE_DATE");
            entity.Property(e => e.FeeNetVat)
                .HasComment("Provided in positive terms, to reflect income for PP")
                .HasColumnName("FEE_NET_VAT");
            entity.Property(e => e.FeeTypeId).HasColumnName("FEE_TYPE_ID");
            entity.Property(e => e.Hurdle).HasColumnName("HURDLE");
            entity.Property(e => e.IncomeBankId).HasColumnName("INCOME_BANK_ID");
            entity.Property(e => e.MgmtFee).HasColumnName("MGMT_FEE");
            entity.Property(e => e.PerfFee).HasColumnName("PERF_FEE");
            entity.Property(e => e.RiskProfile)
                .HasMaxLength(45)
                .HasColumnName("RISK_PROFILE");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<LastestInstrumentValuationRepCur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("lastest_instrument_valuation_rep_cur");

            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.BpipeReferenceSecurityClass)
                .HasMaxLength(45)
                .HasColumnName("bpipe_reference_security_class");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotType)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("INT_ACC");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.ModDur)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MOD_DUR");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.ValueLoc).HasColumnName("VALUE_LOC");
            entity.Property(e => e.ValueReportingCurrency).HasColumnName("VALUE_REPORTING_CURRENCY");
        });

        modelBuilder.Entity<LatestAvailableInstrumentHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_available_instrument_holdings");

            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
        });

        modelBuilder.Entity<LatestCashHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_cash_holdings");

            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AmountAccCur).HasColumnName("AMOUNT_ACC_CUR");
            entity.Property(e => e.AmountDkk).HasColumnName("AMOUNT_DKK");
            entity.Property(e => e.AmountRepCur).HasColumnName("AMOUNT_REP_CUR");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
        });

        modelBuilder.Entity<LatestCashHoldingsDkk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_cash_holdings_dkk");

            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AmountAccCur).HasColumnName("AMOUNT_ACC_CUR");
            entity.Property(e => e.AmountDkk).HasColumnName("AMOUNT_DKK");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
        });

        modelBuilder.Entity<LatestClientAggCashHoldingsDkk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_client_agg_cash_holdings_dkk");

            entity.Property(e => e.CashDkk).HasColumnName("CASH_DKK");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
        });

        modelBuilder.Entity<LatestClientAssetClassAlloc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_client_asset_class_alloc");

            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.AssetClassPct).HasColumnName("ASSET_CLASS_PCT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<LatestClientFtNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_client_ft_numbers");

            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.FtRenterisikoTotal).HasColumnName("FT Renterisiko Total");
            entity.Property(e => e.FtRenterisikoÆndring).HasColumnName("FT Renterisiko ændring");
            entity.Property(e => e.FtVar).HasColumnName("FT_VAR");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.KurslisteTotal).HasColumnName("Kursliste Total");
            entity.Property(e => e.KurslisteÆndring).HasColumnName("Kursliste ændring");
            entity.Property(e => e.ModelbaseretTotal).HasColumnName("Modelbaseret Total");
            entity.Property(e => e.ModelbaseretÆndring).HasColumnName("Modelbaseret ændring");
        });

        modelBuilder.Entity<LatestClientInstHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_client_inst_holdings");

            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
        });

        modelBuilder.Entity<LatestFundCashHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_fund_cash_holdings");

            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<LatestFundInstHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_fund_inst_holdings");

            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
            entity.Property(e => e.Weight).HasColumnName("WEIGHT");
        });

        modelBuilder.Entity<LatestInstrumentHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_instrument_holdings");

            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("INT_ACC");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
            entity.Property(e => e.ValueRepCur).HasColumnName("VALUE_REP_CUR");
        });

        modelBuilder.Entity<LatestInstrumentHoldingsValuationDkk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_instrument_holdings_valuation_dkk");

            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("INT_ACC");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
            entity.Property(e => e.ValueInstCur).HasColumnName("VALUE_INST_CUR");
            entity.Property(e => e.ValueRepCur).HasColumnName("VALUE_REP_CUR");
        });

        modelBuilder.Entity<LatestInstrumentPricesWithTickersAndIsin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_instrument_prices_with_tickers_and_isin");

            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc).HasColumnName("INT_ACC");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.ModDur).HasColumnName("MOD_DUR");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.PriceDate)
                .HasColumnType("datetime")
                .HasColumnName("PRICE_DATE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
        });

        modelBuilder.Entity<MgmtFeeCalcCashHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mgmt_fee_calc_cash_holdings");

            entity.Property(e => e.BillingCurrency)
                .HasMaxLength(3)
                .HasDefaultValueSql("'DKK'")
                .HasColumnName("BILLING_CURRENCY");
            entity.Property(e => e.CashBilCur).HasColumnName("CASH_BIL_CUR");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.DepotId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DEPOT_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.IsOnelife).HasColumnName("IS_ONELIFE");
            entity.Property(e => e.MgmtFee).HasColumnName("MGMT_FEE");
            entity.Property(e => e.MgmtFeeBilCur).HasColumnName("MGMT_FEE_BIL_CUR");
            entity.Property(e => e.MgmtFeeBilCurInclVat).HasColumnName("MGMT_FEE_BIL_CUR_INCL_VAT");
            entity.Property(e => e.MgmtFeeCashFilter).HasColumnName("MGMT_FEE_CASH_FILTER");
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatBilCur).HasColumnName("VAT_BIL_CUR");
        });

        modelBuilder.Entity<MgmtFeeCalcInstHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mgmt_fee_calc_inst_holdings");

            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.BillingCurrency)
                .HasMaxLength(3)
                .HasDefaultValueSql("'DKK'")
                .HasColumnName("BILLING_CURRENCY");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.CountryFiltFee).HasColumnName("COUNTRY_FILT_FEE");
            entity.Property(e => e.CountryIso)
                .HasMaxLength(10)
                .HasColumnName("COUNTRY_ISO");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentFiltFee).HasColumnName("INSTRUMENT_FILT_FEE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IsOnelife)
                .HasDefaultValueSql("'0'")
                .HasColumnName("IS_ONELIFE");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.MarketValueBilCur).HasColumnName("MARKET_VALUE_BIL_CUR");
            entity.Property(e => e.MgmtFee).HasColumnName("MGMT_FEE");
            entity.Property(e => e.MgmtFeeBilCur).HasColumnName("MGMT_FEE_BIL_CUR");
            entity.Property(e => e.MgmtFeeBilCurInclVat).HasColumnName("MGMT_FEE_BIL_CUR_INCL_VAT");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SimpleFiltFee).HasColumnName("SIMPLE_FILT_FEE");
            entity.Property(e => e.ThematicFee).HasColumnName("THEMATIC_FEE");
            entity.Property(e => e.Vat).HasColumnName("VAT");
            entity.Property(e => e.VatBilCur).HasColumnName("VAT_BIL_CUR");
        });

        modelBuilder.Entity<MgmtPerfFeesView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("mgmt_perf_fees_view");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Comment)
                .HasMaxLength(300)
                .HasColumnName("COMMENT");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.FeeDate)
                .HasColumnType("datetime")
                .HasColumnName("FEE_DATE");
            entity.Property(e => e.FeeDescription)
                .HasMaxLength(255)
                .HasColumnName("FEE_DESCRIPTION");
            entity.Property(e => e.FeeGrossVat)
                .HasComment("Provided in negative terms to reflect cash impact on client account")
                .HasColumnName("FEE_GROSS_VAT");
            entity.Property(e => e.FeeNetVat)
                .HasComment("Provided in positive terms, to reflect income for PP")
                .HasColumnName("FEE_NET_VAT");
            entity.Property(e => e.FeeTypeId).HasColumnName("FEE_TYPE_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IncomeBankId).HasColumnName("INCOME_BANK_ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.PpTransaction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.PricePp).HasColumnName("PRICE_PP");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<OnTopOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("on_top_overview");

            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.OnTop).HasColumnName("ON_TOP");
        });

        modelBuilder.Entity<RealrådView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("realråd_view");

            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.AmountPp).HasColumnName("AMOUNT_PP");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.ExRate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("EX_RATE");
            entity.Property(e => e.Indtjening).HasComment("Provided in positive terms, to reflect income for PP");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Omkostning).HasDefaultValueSql("'0'");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.PricePp).HasColumnName("PRICE_PP");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<ReturnGroupOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("return_group_overview");

            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.GroupName)
                .HasMaxLength(65)
                .HasColumnName("GROUP_NAME");
            entity.Property(e => e.IdReturnGroup).HasColumnName("ID_RETURN_GROUP");
            entity.Property(e => e.ReturnGroup).HasColumnName("RETURN_GROUP");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
        });

        modelBuilder.Entity<ReturnOverviewToTeam>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("return_overview_to_team");

            entity.Property(e => e.BmId).HasColumnName("BM_ID");
            entity.Property(e => e.BmReturn)
                .HasDefaultValueSql("'0'")
                .HasColumnName("BM_RETURN");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.ClientType)
                .HasMaxLength(45)
                .HasColumnName("CLIENT_TYPE");
            entity.Property(e => e.DkkReturnActual).HasColumnName("DKK_RETURN_ACTUAL");
            entity.Property(e => e.DkkReturnWCash).HasColumnName("DKK_RETURN_W_CASH");
            entity.Property(e => e.DkkReturnWoCash).HasColumnName("DKK_RETURN_WO_CASH");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PortfolioReturnActual).HasColumnName("PORTFOLIO_RETURN_ACTUAL");
            entity.Property(e => e.PortfolioReturnWCash).HasColumnName("PORTFOLIO_RETURN_W_CASH");
            entity.Property(e => e.PortfolioReturnWoCash).HasColumnName("PORTFOLIO_RETURN_WO_CASH");
            entity.Property(e => e.ReturnDate)
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
            entity.Property(e => e.SigIoActualId).HasColumnName("SIG_IO_ACTUAL_ID");
            entity.Property(e => e.SigIoWCashId).HasColumnName("SIG_IO_W_CASH_ID");
            entity.Property(e => e.SigIoWoCashId).HasColumnName("SIG_IO_WO_CASH_ID");
        });

        modelBuilder.Entity<SecurityTransactionsAmountDkk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("security_transactions_amount_dkk");

            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.AmountDkk).HasColumnName("AMOUNT_DKK");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.Counterpart).HasColumnName("COUNTERPART");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.PpTransaction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.Reverse).HasColumnName("REVERSE");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<SecurityTransactionsView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("security_transactions_view");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.CashImpact).HasColumnName("CASH_IMPACT");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Counterpart).HasColumnName("COUNTERPART");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.NominalImpact).HasColumnName("NOMINAL_IMPACT");
            entity.Property(e => e.PpTransaction)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PP_TRANSACTION");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.Reverse).HasColumnName("REVERSE");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeId).HasColumnName("TRADE_TYPE_ID");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<StockpickCashExcelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("stockpick_cash_excel_view");

            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AmountAccCur).HasColumnName("AMOUNT_ACC_CUR");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
        });

        modelBuilder.Entity<StockpickPortfolioExcelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("stockpick_portfolio_excel_view");

            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
        });

        modelBuilder.Entity<StockpickTransactionsExcelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("stockpick_transactions_excel_view");

            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.AmountDkk).HasColumnName("AMOUNT_DKK");
            entity.Property(e => e.Comment).HasColumnName("COMMENT");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.ExRate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("EX_RATE");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeName)
                .HasMaxLength(255)
                .HasColumnName("TRADE_TYPE_NAME");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<TaktikCashExcelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("taktik_cash_excel_view");

            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.AmountAccCur).HasColumnName("AMOUNT_ACC_CUR");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
        });

        modelBuilder.Entity<TaktikPortfolioExcelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("taktik_portfolio_excel_view");

            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
        });

        modelBuilder.Entity<TaktikTransactionsExcelView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("taktik_transactions_excel_view");

            entity.Property(e => e.Amount).HasColumnName("AMOUNT");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.TradeTypeName)
                .HasMaxLength(255)
                .HasColumnName("TRADE_TYPE_NAME");
            entity.Property(e => e.TransactionId).HasColumnName("TRANSACTION_ID");
            entity.Property(e => e.ValueDate)
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<TotalClientInflowOutflowOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("total_client_inflow_outflow_overview");

            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.InflowOutflow).HasColumnName("INFLOW_OUTFLOW");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
        });

        modelBuilder.Entity<TradingBookActiveAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("trading_book_active_accounts");

            entity.Property(e => e.Account)
                .HasMaxLength(45)
                .HasColumnName("ACCOUNT");
            entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");
            entity.Property(e => e.Bank)
                .HasMaxLength(255)
                .HasColumnName("BANK");
            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BankId).HasColumnName("BANK_ID");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.CountryName)
                .HasMaxLength(45)
                .HasColumnName("COUNTRY_NAME");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotTypeDa)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE_DA");
            entity.Property(e => e.DepotTypeId).HasColumnName("DEPOT_TYPE_ID");
            entity.Property(e => e.Ec)
                .HasMaxLength(255)
                .HasColumnName("EC");
            entity.Property(e => e.Iban)
                .HasMaxLength(40)
                .HasColumnName("IBAN");
            entity.Property(e => e.JbCode)
                .HasMaxLength(255)
                .HasColumnName("JB_CODE");
        });

        modelBuilder.Entity<TradingBookActiveInstrumentsWithLatestPrice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("trading_book_active_instruments_with_latest_prices");

            entity.Property(e => e.AssetClass)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ASSET_CLASS");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Deduction).HasColumnName("DEDUCTION");
            entity.Property(e => e.ExRate)
                .HasDefaultValueSql("'0'")
                .HasColumnName("EX_RATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("INT_ACC");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.Issuer)
                .HasMaxLength(90)
                .HasColumnName("issuer");
            entity.Property(e => e.ModDur)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MOD_DUR");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.PriceDate)
                .HasColumnType("datetime")
                .HasColumnName("PRICE_DATE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
        });

        modelBuilder.Entity<TradingBookMarginOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("trading_book_margin_overview");

            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_NAME");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.ClientType)
                .HasMaxLength(45)
                .HasColumnName("CLIENT_TYPE");
            entity.Property(e => e.ContractType)
                .HasMaxLength(45)
                .HasColumnName("CONTRACT_TYPE");
        });

        modelBuilder.Entity<TradingBookMonthlyDkkReturn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("trading_book_monthly_dkk_returns");

            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.DkkReturn).HasColumnName("DKK_RETURN");
            entity.Property(e => e.ReturnDate)
                .HasComment("All daily return dates in PP history. Based on dex_dafkast from Access and all prior open days on OMXCSE.")
                .HasColumnType("datetime")
                .HasColumnName("RETURN_DATE");
        });

        modelBuilder.Entity<TransactionListView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("transaction_list_view");

            entity.Property(e => e.AmountRepCurrency).HasColumnName("AMOUNT_REP_CURRENCY");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.ExRateRep).HasColumnName("EX_RATE_REP");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.PpCostRepCur).HasColumnName("PP_COST_REP_CUR");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.ThirdPartyCostRepCur).HasColumnName("THIRD_PARTY_COST_REP_CUR");
            entity.Property(e => e.TradeDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.ValueDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<TurnoverOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("turnover_overview");

            entity.Property(e => e.AmountDkk).HasColumnName("AMOUNT_DKK");
            entity.Property(e => e.DepotId)
                .HasDefaultValueSql("'0'")
                .HasColumnName("DEPOT_ID");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.TradeDate)
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
        });

        modelBuilder.Entity<UnderlyingFundCashHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("underlying_fund_cash_holdings");

            entity.Property(e => e.BbTicker)
                .HasColumnType("mediumtext")
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.SecurityName)
                .HasColumnType("mediumtext")
                .HasColumnName("security_name");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
        });

        modelBuilder.Entity<UnderlyingFundCashHoldingsWithPct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("underlying_fund_cash_holdings_with_pct");

            entity.Property(e => e.BbTicker)
                .HasColumnType("mediumtext")
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.PctShare).HasColumnName("pct_share");
            entity.Property(e => e.SecurityName)
                .HasColumnType("mediumtext")
                .HasColumnName("security_name");
            entity.Property(e => e.ValueDkk).HasColumnName("VALUE_DKK");
        });

        modelBuilder.Entity<VallerodAssetClassesAlloc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vallerod_asset_classes_alloc");

            entity.Property(e => e.AllocDate)
                .HasColumnType("datetime")
                .HasColumnName("ALLOC_DATE");
            entity.Property(e => e.AlternativerPct).HasColumnName("Alternativer_PCT");
            entity.Property(e => e.EquityPct).HasColumnName("Equity_PCT");
            entity.Property(e => e.KontantPct).HasColumnName("Kontant_PCT");
            entity.Property(e => e.KreditobligationerPct).HasColumnName("Kreditobligationer_PCT");
            entity.Property(e => e.RealkreditobligationerPct).HasColumnName("Realkreditobligationer_PCT");
            entity.Property(e => e.StatsobligationerPct).HasColumnName("Statsobligationer_PCT");
        });

        modelBuilder.Entity<VallerodBenchmarkReturn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vallerod_benchmark_returns");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InputDate)
                .HasColumnType("datetime")
                .HasColumnName("INPUT_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc).HasColumnName("INT_ACC");
            entity.Property(e => e.ModDur).HasColumnName("MOD_DUR");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.PriceDate)
                .HasColumnType("datetime")
                .HasColumnName("PRICE_DATE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
        });

        modelBuilder.Entity<VallerodInstrumentHoldingsAsset>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vallerod_instrument_holdings_assets");

            entity.Property(e => e.BankExecutionId)
                .HasMaxLength(45)
                .HasColumnName("BANK_EXECUTION_ID");
            entity.Property(e => e.BbTicker)
                .HasMaxLength(45)
                .HasColumnName("BB_TICKER");
            entity.Property(e => e.BpipeReferenceSecurityClass)
                .HasMaxLength(45)
                .HasColumnName("bpipe_reference_security_class");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.DepotId).HasColumnName("DEPOT_ID");
            entity.Property(e => e.DepotType)
                .HasMaxLength(255)
                .HasColumnName("DEPOT_TYPE");
            entity.Property(e => e.HoldingDate)
                .HasColumnType("datetime")
                .HasColumnName("HOLDING_DATE");
            entity.Property(e => e.InstrumentId).HasColumnName("INSTRUMENT_ID");
            entity.Property(e => e.IntAcc)
                .HasDefaultValueSql("'0'")
                .HasColumnName("INT_ACC");
            entity.Property(e => e.InterestAccRepCur).HasColumnName("INTEREST_ACC_REP_CUR");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.ModDur)
                .HasDefaultValueSql("'0'")
                .HasColumnName("MOD_DUR");
            entity.Property(e => e.Price)
                .HasDefaultValueSql("'0'")
                .HasColumnName("PRICE");
            entity.Property(e => e.PriceFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRICE_FACTOR");
            entity.Property(e => e.PrincipalFactor)
                .HasDefaultValueSql("'1'")
                .HasColumnName("PRINCIPAL_FACTOR");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.ValueLoc).HasColumnName("VALUE_LOC");
            entity.Property(e => e.ValueReportingCurrency).HasColumnName("VALUE_REPORTING_CURRENCY");
        });

        modelBuilder.Entity<VallerodTransactionsAsset>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vallerod_transactions_assets");

            entity.Property(e => e.AmountRepCurrency).HasColumnName("AMOUNT_REP_CURRENCY");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.ExRateRep).HasColumnName("EX_RATE_REP");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.PpCostRepCur).HasColumnName("PP_COST_REP_CUR");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.ThirdPartyCostRepCur).HasColumnName("THIRD_PARTY_COST_REP_CUR");
            entity.Property(e => e.TradeDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.ValueDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        modelBuilder.Entity<VallerodTransactionsAssetsFinal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vallerod_transactions_assets_final");

            entity.Property(e => e.AmountRepCurrency).HasColumnName("AMOUNT_REP_CURRENCY");
            entity.Property(e => e.AssetClassOrSecurityClass)
                .HasMaxLength(45)
                .HasColumnName("asset_class_or_security_class");
            entity.Property(e => e.ClientPpId).HasColumnName("CLIENT_PP_ID");
            entity.Property(e => e.Currency)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("CURRENCY");
            entity.Property(e => e.Depot)
                .HasMaxLength(45)
                .HasColumnName("DEPOT");
            entity.Property(e => e.ExRateRep).HasColumnName("EX_RATE_REP");
            entity.Property(e => e.Isin)
                .HasMaxLength(45)
                .HasColumnName("ISIN");
            entity.Property(e => e.PpCostRepCur).HasColumnName("PP_COST_REP_CUR");
            entity.Property(e => e.Price).HasColumnName("PRICE");
            entity.Property(e => e.Quantity).HasColumnName("QUANTITY");
            entity.Property(e => e.SecurityName)
                .HasMaxLength(90)
                .HasColumnName("security_name");
            entity.Property(e => e.ThirdPartyCostRepCur).HasColumnName("THIRD_PARTY_COST_REP_CUR");
            entity.Property(e => e.TradeDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("TRADE_DATE");
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.ValueDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("VALUE_DATE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
