using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Models;
using Shared.Enums;

namespace DataAccess.FileAccess.BankFileTypes.SparNord;

public class InstrumentHolding : BankHolding
{
    public override string Currency => _currency;
    public override string AccountName => account;
    public override HoldingType HoldingType => HoldingType.Instrument;
    public override string ISIN => _isin;
    public override decimal? Amount => null;
    public override decimal? Quantity => _quantity;
    // Subtract 1 day from holdings in SparNord
    public override DateTime HoldingDate => Date.AddDays(-1);
    [Ignore]
    public string account { get; set; }
    
    [Index(0)]
    public string RecordType {get;set;}
    [Index(1)]
    public string Depot {get;set;}
    [Index(2)]
    public string FundCode {get;set;}
    [Index(3)]
    [Format("yyyyMMdd")]
    public DateTime Date {get;set;}
    [Index(4)]
    public string Price {get;set;}
    [Index(5)]
    public string _currency {get;set;}
    [Index(6)]
    public string SettledHolding {get;set;}
    [Index(7)]
    public string DrawnBondsSettled {get;set;}
    [Index(8)]
    public decimal _quantity {get;set;}
    [Index(9)]
    public string MarketValue {get;set;}
    [Index(10)]
    public string SecurityName {get;set;}
    [Index(11)]
    public string Exchange {get;set;}
    [Index(12)]
    public string _isin {get;set;}
    [Index(13)]
    public string Sedol {get;set;}
    [Index(14)]
    public string CountryISO {get;set;}
    [Index(15)]
    public string SecurityDescription {get;set;}
}