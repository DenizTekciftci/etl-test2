using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using Shared.Consts;
using Shared.Enums;

namespace DataAccess.FileAccess.BankFileTypes.Saxo;

public class MutualFundsOpenPosition : BankHolding
{
    public override DateTime HoldingDate => ReportingDate;
    public override string ISIN => ISINCode;
    public override decimal? Amount => _amount;
    public override decimal? Quantity => _amount;
    public override string Currency => InstrumentCurrency;
    public override string AccountName => AccountNumber;
    public override HoldingType HoldingType => HoldingType.Instrument;
    
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime ReportingDate {get;set;}
    public string InstrumentType {get;set;}
    public string CounterpartID {get;set;}
    public string AccountNumber {get;set;}
    public string PartnerAccountKey {get;set;}
    public string AccountCurrency {get;set;}
    public string InstrumentCode {get;set;}
    public string InstrumentDescription {get;set;}
    public string InstrumentCurrency {get;set;}
    public string ISINCode {get;set;}
    [Name("Amount")]
    public decimal _amount {get;set;}
    public string FigureSize {get;set;}
    public string TradeNumber {get;set;}
    public string OrderNumber {get;set;}
    public string TradeTime {get;set;}
    public string TradeDate {get;set;}
    public string ValueDate {get;set;}
    public string BuySell {get;set;}
    public string TradedPrice {get;set;}
    public string QuotedValue {get;set;}
    public string EODRate {get;set;}
    public string InstrumentToAccountRate {get;set;}
    public string IsPartial {get;set;}
    public string UnrealisedValueInstrument {get;set;}
    public string UnrealisedValueAccount {get;set;}
    public string ExternalOrderID {get;set;}
    public string PreviousISINCode {get;set;}
    public string InstrumentUIC {get;set;}
    public string QuotedValueBaseCurrency {get;set;}
    public string UnrealisedValueBaseCurrency {get;set;}
}