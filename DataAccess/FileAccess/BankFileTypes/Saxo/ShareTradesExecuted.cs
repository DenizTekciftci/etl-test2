using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Enums;
using DataAccess.DatabaseAccess.Models;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.Saxo;

public class ShareTradesExecuted : BankTransaction
{
    public override string TradeType => BuySell;
    public override string Account => AccountNumber;
    public override double Price => _price;
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

    public override string ISIN => ISINCode;
    public override DateTime TradeDate => _tradeDate;
    public override DateTime ValueDate => _valueDate;
    public override string Currency => InstrumentCurrency;

    [Format(DateStringFormats.yyyyMMdd)] public DateTime ReportingDate { get; set; }
    [Name("TradeDate")]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime _tradeDate { get; set; }
    [Name("ValueDate")]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime _valueDate { get; set; }

    public string? InstrumentType { get; set; }
    public string? CounterpartID { get; set; }
    public string AccountNumber { get; set; }
    public string? PartnerAccountKey { get; set; }
    public string? AccountCurrency { get; set; }
    public string? InstrumentCode { get; set; }
    public string? InstrumentDescription { get; set; }
    public string InstrumentCurrency { get; set; }
    public string ISINCode { get; set; }
    public string? ExchangeDescription { get; set; }
    public double TradedAmount { get; set; }
    public string? FigureSize { get; set; }
    public string? TradeNumber { get; set; }
    public string? OrderNumber { get; set; }
    public string? TradeTime { get; set; }

    public string BuySell { get; set; }

    public double QuotedValueInstrumentCurrency { get; set; }
    [Name("Price")] public double _price { get; set; }
    public double CommissionInstrumentCurrency { get; set; }
    public double ExchangeFeeInstrumentCurrency { get; set; }
    public string? TransferFee { get; set; }
    public double TaxInstrumentCurrency { get; set; }
    public string? RelatedTradeID { get; set; }

    public string? CAEventTypeName { get; set; }
    public string? CAEventID { get; set; }
    public string? TradeAllocation { get; set; }
    public string? RootTradeID { get; set; }
    public string? ExternalOrderID { get; set; }
    public string? OriginalTradeID { get; set; }
    public string? CorrectionLeg { get; set; }
    public string? PositionID { get; set; }
    public string? InstrumentUIC { get; set; }
    public string? ExchangeISOCode { get; set; }
    public string? ISOMic { get; set; }
    public string? ETORelatedClosingTrade { get; set; }
    public string? CAEventTypeID { get; set; }
    public string? DVP { get; set; }
    public string? EODRate { get; set; }
    public string? ActualTradeDate { get; set; }
    public string? ExecutingEntityIdentificationCode { get; set; }
    public string? UserIdOnTrade { get; set; }
    public string? EmployeeId { get; set; }
    public string? DecisionMakerUserId { get; set; }
    public string? Venue { get; set; }
    public string? TradeExecutionTime { get; set; }
    public string? ShortSellingIndicator { get; set; }
    public string? OTCPostTradeIndicator { get; set; }
    public string? SecuritiesFinancingTransactionIndicator { get; set; }
    public string? SaxoPortfolioManagerTriggered { get; set; }
    public string? CorrelationKey { get; set; }
    public string? InstrumentSubType { get; set; }
    public string? ParentInstrumentUIC { get; set; }
    public string? ParentInstrumentName { get; set; }
    public double AdditionalTransactionCostInstrumentCurrency { get; set; }
    public string? OriginatingTool { get; set; }
    public string? WithAdvice { get; set; }
    public string? OperatingMIC { get; set; }
    public string? EventDescription { get; set; }
    public string? TradeTags { get; set; }
    public string? TradeTagsNames { get; set; }
    public string? TransactionDescription { get; set; }
    public string? CorporateActionReference { get; set; }

    public override List<(string costType, double cost)> GetCosts()
    {
        return
        [
            (nameof(CommissionInstrumentCurrency), CommissionInstrumentCurrency),
            (nameof(ExchangeFeeInstrumentCurrency), ExchangeFeeInstrumentCurrency),
            (nameof(TaxInstrumentCurrency), TaxInstrumentCurrency),
            (nameof(AdditionalTransactionCostInstrumentCurrency), AdditionalTransactionCostInstrumentCurrency),
        ];
    }
}