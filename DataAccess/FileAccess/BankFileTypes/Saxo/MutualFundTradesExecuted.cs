using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.Saxo;

public class MutualFundTradesExecuted : BankTransaction
{
    [Format(DateStringFormats.yyyyMMdd)]
    public override DateTime TradeDate => _tradeDate;
    [Format(DateStringFormats.yyyyMMdd)]
    public override DateTime ValueDate => _valueDate;
    public override string Currency => InstrumentCurrency;
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
    public override string TradeType => BuySell;
    public override string Account => AccountNumber;
    public override List<(string, double)> GetCosts()
    {
        return
        [
            (nameof(CommissionInstrumentCurrency), CommissionInstrumentCurrency),
            (nameof(TaxInstrumentCurrency), TaxInstrumentCurrency),
            (nameof(AdditionalTransactionCostInstrumentCurrency), AdditionalTransactionCostInstrumentCurrency),
        ];
    }
    
    [Name("TradeDate")]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime _tradeDate { get; set; }
    [Name("ValueDate")]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime _valueDate { get; set; }
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime ReportingDate { get; set; }
    [Name("Price")] 
    public double _price { get; set; }
    public string InstrumentType { get; set; }
    public string CounterpartID { get; set; }
    public string AccountNumber { get; set; }
    public string PartnerAccountKey { get; set; }
    public string AccountCurrency { get; set; }
    public string InstrumentCode { get; set; }
    public string InstrumentDescription { get; set; }
    public string InstrumentCurrency { get; set; }
    public string ISINCode { get; set; }
    public double TradedAmount { get; set; }
    public string FigureSize { get; set; }
    public string TradeNumber { get; set; }
    public string OrderNumber { get; set; }
    public string TradeTime { get; set; }

    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime ActualTradeDate { get; set; }
    public string BuySell { get; set; }
    public double QuotedValueInstrumentCurrency { get; set; }
    public double CommissionInstrumentCurrency { get; set; }
    public double TaxInstrumentCurrency { get; set; }
    public string RelatedTradeID { get; set; }
    public string TradeAllocation { get; set; }
    public string RootTradeID { get; set; }
    public string ExternalOrderID { get; set; }
    public string OriginalTradeID { get; set; }
    public string CorrectionLeg { get; set; }
    public string PositionID { get; set; }
    public string InstrumentUIC { get; set; }
    public string EODRate { get; set; }
    public string CorrelationKey { get; set; }
    public double AdditionalTransactionCostInstrumentCurrency { get; set; }
    public string OriginatingTool { get; set; }
    public string WithAdvice { get; set; }
    public string TransactionDescription { get; set; }
}