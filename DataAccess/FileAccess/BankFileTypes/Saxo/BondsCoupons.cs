using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.Saxo;

public class BondsCoupons : BankTransaction
{
    public override string TradeType => BkAmountType;
    public override string Account => AccountNumber;
    public override double Price => 0;
    [Ignore]
    public override double Quantity { get; set; }

    [Ignore]
    public override double Amount
    {
        get => GrossAmountCouponCurrency;
        set => GrossAmountCouponCurrency = value;
    }

    public override string ISIN => _isin;
    public override DateTime TradeDate => _tradeDate;
    public override DateTime ValueDate => _valueDate;
    public override string Currency => InstrumentCurrency;
    [Name("ISIN")]
    public string _isin { get; set; }
    [Name("TradeDate")]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime _tradeDate { get; set; }
    [Name("ValueDate")]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime _valueDate { get; set; }
    public string InstrumentType { get; set; }
    public string CounterpartID { get; set; }
    public string AccountNumber { get; set; }
    public string AccountCurrency { get; set; }
    public string TradeNumber { get; set; }
    public string FigureSize { get; set; }
    public string InstrumentCode { get; set; }
    public string InstrumentDescription { get; set; }
    public string InstrumentCurrency { get; set; }
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime CouponDate { get; set; }
    [Format(DateStringFormats.yyyyMMdd)]
    public string HoldingAmount { get; set; }
    public string PositionType { get; set; }
    public string Rate { get; set; }
    public string ExCouponDate { get; set; }
    public string Factor { get; set; }
    public string BkAmountType { get; set; }
    public double GrossAmountCouponCurrency { get; set; }
    public string GrossAmountAccountCurrency { get; set; }
    public string WithholdingTaxPercentage { get; set; }
    public double WithholdingTaxAmountCouponCurrency { get; set; }
    public string NetAmountAccountCurrency { get; set; }
    public string CountryofIssue { get; set; }
    public string WithholdingTaxAmountAccountCurrency { get; set; }
    public string CouponCurrency { get; set; }
    public double CouponToAccountRate { get; set; }
    public string PartnerAccountKey { get; set; }
    [Format(DateStringFormats.yyyyMMdd)]
    public string InstrumentSubType { get; set; }
    public string CAEventID { get; set; }
    public string IssuerName { get; set; }
    public string InstrumentUIC { get; set; }
    public double ResidencyTaxAmountCouponCurrency { get; set; }
    public double ResidencyTaxAmountAccountCurrency { get; set; }
    public string ResidencyTaxPercentage { get; set; }
    public string CAEventTypeName { get; set; }
    public string IndexRatio { get; set; }
    public string SocialTaxPercentage { get; set; }
    public string SocialTaxAmountDividendCurrency { get; set; }
    public string AdvancedIncomeTaxPercentage { get; set; }
    public string AdvancedIncomeTaxDividendCurrency { get; set; }
    public string TransactionDescription { get; set; }

    [Ignore]
    public double quantity { get; set; }
    
    public override List<(string, double)> GetCosts()
    {
        return
        [
            (nameof(WithholdingTaxAmountCouponCurrency), WithholdingTaxAmountCouponCurrency),
            (nameof(ResidencyTaxAmountCouponCurrency), ResidencyTaxAmountCouponCurrency),
            (nameof(ResidencyTaxAmountAccountCurrency), ResidencyTaxAmountAccountCurrency),
        ];
    }
}