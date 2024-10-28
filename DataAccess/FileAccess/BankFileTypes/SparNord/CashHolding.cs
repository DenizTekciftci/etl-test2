using CsvHelper.Configuration.Attributes;
using Shared.Consts;
using Shared.Enums;

namespace DataAccess.FileAccess.BankFileTypes.SparNord;

public class CashHolding : BankHolding
{
    [Index(0)]
    public string RECORD_TYPE {get; set;}
    [Index(1)]
    public string ACCOUNT {get; set;}
    [Index(2)]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime DATE {get; set;}
    [Index(3)]
    public string CURRENCY {get; set;}
    [Index(4)]
    public decimal AMOUNT {get; set;}
    [Index(5)]
    public string ACCRUED_INTEREST {get; set;}

    // Subtract 1 day from holdings in SparNord
    public override DateTime HoldingDate => DATE.AddDays(-1);
    public override string ISIN => "";
    public override decimal? Amount => AMOUNT;
    public override decimal? Quantity => null;
    public override string Currency => CURRENCY;
    public override string AccountName => ACCOUNT;
    public override HoldingType HoldingType => HoldingType.Cash;
}