using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.Saxo;

public class ShareDividend : BankTransaction
{
    public override string TradeType => Consts.CorporateActionTools + CAEventTypeName;
    public override string Account => AccountNumber;
    public override double Price => 0;
    [Ignore]
    public override double Quantity
    {
        get => EligibleQuantity;
        set => EligibleQuantity = value;
    }

    [Ignore]
    public override double Amount
    {
        get => NetAmountDividendCurrency;
        set => NetAmountDividendCurrency = value;
    }

    public override string ISIN => ISINCode;
    public override DateTime TradeDate => _tradeDate;
    public override DateTime ValueDate => _valueDate;
    public override string Currency => DividendCurrency;
    public string InstrumentType { get; set; }
    public string CAEventID { get; set; }
    public string ExDate { get; set; }
    [Name("TradeDate")]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime _tradeDate { get; set; }
    [Name("TradeDate")]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime _valueDate { get; set; }
    public string CounterpartID { get; set; }
    public string AccountNumber { get; set; }
    public string PartnerAccountKey { get; set; }
    public string AccountCurrency { get; set; }
    public string TradeNumber { get; set; }
    public string InstrumentDescription { get; set; }
    public string InstrumentCode { get; set; }
    public string ISINCode { get; set; }
    public string CountryOfIssue { get; set; }
    public string FigureSize { get; set; }
    public string InstrumentCurrency { get; set; }
    public double EligibleQuantity { get; set; }
    public string PositionType { get; set; }
    public double NetAmountDividendCurrency { get; set; }
    public string DividendToAccountRate { get; set; }
    public string NetAmountAccountCurrency { get; set; }
    public double WithholdingTaxPercentage { get; set; }
    public string WithholdingTaxAmountDividendCurrency { get; set; }
    public string GrossAmountDividendCurrency { get; set; }
    public string DividendCurrency { get; set; }
    public string FrankedAmountDividendCurrency { get; set; }
    public string UnFrankedAmountDividendCurrency { get; set; }
    public string FrankingCreditDividendCurrency { get; set; }
    public string GrossRate { get; set; }
    public string CAEventTypeID { get; set; }
    public string CAEventTypeName { get; set; }
    public string ExchangeISOCode { get; set; }
    public string ISOMic { get; set; }
    public string InstrumentUIC { get; set; }
    public string GrossDividendAmountDividendCurrency { get; set; }
    public double InterestAmountDividendCurrency { get; set; }
    public string ResidencyTaxPercentage { get; set; }
    public double ResidencyTaxAmountDividendCurrency { get; set; }
    public string EUTaxPercentage { get; set; }
    public double EUTaxAmountDividendCurrency { get; set; }
    public double FeeAmountDividendCurrency { get; set; }
    public string SocialTaxPercentage { get; set; }
    public string SocialTaxAmountDividendCurrency { get; set; }
    public string AdvancedIncomeTaxPercentage { get; set; }
    public string AdvancedIncomeTaxDividendCurrency { get; set; }
    public string USWithholdingTaxSwissClientsPercentage { get; set; }
    public string USWithholdingTaxSwissClientsDividendCurrency { get; set; }
    public string OperatingMIC { get; set; }
    public string CorrectionLeg { get; set; }
    public string ForeignIncomeAmountDividendCurrency { get; set; }
    public string ForeignIncomeTaxPercentage { get; set; }
    public string JPNationalWithholdingTax { get; set; }
    public string JPResidentWithholdingTax { get; set; }
    public string TransactionDescription { get; set; }
    public string CorporateActionReference { get; set; }
    public override List<(string costType, double cost)> GetCosts()
    {
        return
        [
            (nameof(WithholdingTaxPercentage), WithholdingTaxPercentage),
            (nameof(InterestAmountDividendCurrency), InterestAmountDividendCurrency),
            (nameof(ResidencyTaxAmountDividendCurrency), ResidencyTaxAmountDividendCurrency),
            (nameof(EUTaxAmountDividendCurrency), EUTaxAmountDividendCurrency),
            (nameof(FeeAmountDividendCurrency), FeeAmountDividendCurrency),
        ];
    }
}