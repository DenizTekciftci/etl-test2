using CsvHelper.Configuration.Attributes;

namespace DataAccess.FileAccess.BankFileTypes.Saxo;

public class BondsTradesExecuted : BankTransaction
{
    public string ReportingDate { get; set; }
    public string InstrumentType { get; set; }
    public string CounterpartID { get; set; }
    public string AccountNumber { get; set; }
    public string PartnerAccountKey { get; set; }
    public string AccountCurrency { get; set; }
    public string InstrumentCode { get; set; }
    public string InstrumentDescription { get; set; }
    [Name("ISIN")] public string isin { get; set; }
    public string IssueDate { get; set; }
    public string InstrumentCurrency { get; set; }
    public string ExchangeDescription { get; set; }
    public string MaturityDate { get; set; }
    public double TradedAmount { get; set; }
    public string FigureSize { get; set; }
    public string TradeNumber { get; set; }
    public string OrderNumber { get; set; }
    public string TradeTime { get; set; }
    [Name("TradeDate")] public DateTime tradeDate { get; set; }
    [Name("ValueDate")] public DateTime valueDate { get; set; }
    public string BuySell { get; set; }
    public string CleanPrice { get; set; }
    public double QuotedValueInstrumentCurrency { get; set; }
    public double CommissionInstrumentCurrency { get; set; }
    public double ExchangeFeeInstrumentCurrency { get; set; }
    public double StampDutyInstrumentCurrency { get; set; }
    public double TaxAccountCurrency { get; set; }
    public string RelatedTradeID { get; set; }
    [Name("TradeType")] public string tradeType { get; set; }
    public string TradeAllocation { get; set; }
    public string RootTradeID { get; set; }
    public string ExternalOrderID { get; set; }
    public string OriginalTradeID { get; set; }
    public string CorrectionLeg { get; set; }
    public double DirtyPrice { get; set; }
    public string BondType { get; set; }
    public string DrawnRecordID { get; set; }
    public string MaturityRecordID { get; set; }
    public string CountryofIssue { get; set; }
    public string IssuerName { get; set; }
    public string EODInstrumentToAccountRate { get; set; }
    public string AccruedInterestAccountCurrency { get; set; }
    public string EODRateDirtyPrice { get; set; }
    public string ExchangeISOCode { get; set; }
    public string ISOMic { get; set; }
    public string DVP { get; set; }
    public string InstrumentUIC { get; set; }
    public string ActualTradeDate { get; set; }
    public string CAEventID { get; set; }
    public string CAEventTypeName { get; set; }
    public string ExecutingEntityIdentificationCode { get; set; }
    public string TransmissionOfOrderIndicator { get; set; }
    public string NetAmount { get; set; }
    public string UserIdOnTrade { get; set; }
    public string EmployeeId { get; set; }
    public string DecisionMakerUserId { get; set; }
    public string Venue { get; set; }
    public string TradeExecutionTime { get; set; }
    public string ShortSellingIndicator { get; set; }
    public string OTCPostTradeIndicator { get; set; }
    public string CommodityDerivativeIndicator { get; set; }
    public string SecuritiesFinancingTransactionIndicator { get; set; }
    public string SaxoPortfolioManagerTriggered { get; set; }
    public string CorrelationKey { get; set; }
    public string InstrumentSubType { get; set; }
    public double AdditionalTransactionCostInstrumentCurrency { get; set; }
    public string IndexRatio { get; set; }
    public string OriginatingTool { get; set; }
    public string WithAdvice { get; set; }
    public string OperatingMIC { get; set; }
    public string TradeTags { get; set; }
    public string TradeTagsNames { get; set; }
    public string TransactionDescription { get; set; }
    public override DateTime TradeDate => tradeDate;
    public override DateTime ValueDate => valueDate;
    public override string Currency => InstrumentCurrency;
    public override double Price => DirtyPrice;

    [Ignore]
    public override double Quantity
    {
        get => TradedAmount;
        set => TradedAmount = value;
    }

    [Ignore]
    public override double Amount
    {
        get => QuotedValueInstrumentCurrency;
        set => QuotedValueInstrumentCurrency = value;
    }

    public override string ISIN => isin;
    public override string TradeType => tradeType;
    public override string Account => AccountNumber;

    public override List<(string costType, double cost)> GetCosts()
    {
        return
        [
            (nameof(CommissionInstrumentCurrency), CommissionInstrumentCurrency),
            (nameof(ExchangeFeeInstrumentCurrency), ExchangeFeeInstrumentCurrency),
            (nameof(StampDutyInstrumentCurrency), StampDutyInstrumentCurrency),
            (nameof(TaxAccountCurrency), TaxAccountCurrency),
            (nameof(AdditionalTransactionCostInstrumentCurrency), AdditionalTransactionCostInstrumentCurrency),
        ];
    }
}