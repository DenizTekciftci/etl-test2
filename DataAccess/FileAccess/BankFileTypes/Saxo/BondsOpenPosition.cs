using CsvHelper.Configuration.Attributes;
using Shared.Consts;
using Shared.Enums;

namespace DataAccess.FileAccess.BankFileTypes.Saxo;

public class BondsOpenPosition : BankHolding
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
    [Name("ISIN")]
    public string ISINCode {get;set;}
    public string Sector {get;set;}
    public string Instrument {get;set;}
    public string Description {get;set;}
    public string InstrumentCurrency {get;set;}
    public string ExchangeDescription {get;set;}
    public string MaturityDate {get;set;}
    [Name("Amount")]
    public decimal _amount {get;set;}
    public string FigureSize {get;set;}
    public string TradeNumber {get;set;}
    public string OrderNumber {get;set;}
    public string TradeTime {get;set;}
    public string TradeDate {get;set;}
    public string ValueDate {get;set;}
    public string BuySell {get;set;}
    public string CleanPrice {get;set;}
    public string QuotedValue {get;set;}
    public string EODRateCleanPrice {get;set;}
    public string InstrumentToAccountRate {get;set;}
    public string IsPartial {get;set;}
    public string UnrealisedAmountInstrument {get;set;}
    public string UnrealisedAmountAccount {get;set;}
    public string UnrealizedAmountSubjectToWHT {get;set;}
    public string AccruedInterestAccountCurrency {get;set;}
    public string ExternalOrderID {get;set;}
    public string PreviousISINCode {get;set;}
    public string DirtyPrice {get;set;}
    public string Subtype {get;set;}
    public string CountryofIssue {get;set;}
    public string IssuerName {get;set;}
    public string LastCouponDate {get;set;}
    public string CouponFrequency {get;set;}
    public string CouponBasis {get;set;}
    public string EODRateDirtyPrice {get;set;}
    public string AccruedInterestInstrumentCurrency {get;set;}
    public string DVP {get;set;}
    public string IndexRatio {get;set;}
    public string UnrealisedAmountBaseCurrency {get;set;}
    public string UnrealisedAmountSubjectToWHTBase {get;set;}
    public string AccruedInterestBaseCurrency {get;set;}
    public string InstrumentSubType {get;set;}
}