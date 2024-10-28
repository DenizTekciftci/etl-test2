using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.Jyske;


public class Dividend : BankTransaction
{
    [Name("REC-TYPE")]
    public string RecType {get; set;}
    public string DEPOTNR {get; set;}
    public string KONTONR {get; set;}
    public int FONDSKODE {get; set;}
    public string TRANSNR {get; set;}
    [Name("REG-KODE")]
    public string RegKode {get; set;}
    [Format(DateStringFormats.yyyydMMddd)]
    public DateTime UDBYTTEDATO {get; set;}
    [Name("AFKAST-TYPE")]
    public string AfkastType {get; set;}
    public string PAPIRMØNT {get; set;}
    public string KONTOMØNT {get; set;}
    [Name("BOGF-DATO")]
    [Format(DateStringFormats.yyyydMMddd)]
    public DateTime BogfDato {get; set;}
    public string VALUTAKURS {get; set;}
    [Name("DIVIDEND-SATS")]
    public string DividendSats {get; set;}
    [Name("BER-BEHOLDNING")]
    public double BerBeholdning {get; set;}
    public string DIVIDENDE {get; set;}
    public double SKAT {get; set;}
    public double OMKOSTNING {get; set;}
    public double AFREGNINGSBELØB {get; set;}
    [Ignore]
    public string _isin { get; set; }
    public override DateTime TradeDate => UDBYTTEDATO;
    public override DateTime ValueDate => BogfDato;
    public override string Currency => KONTOMØNT;
    public override double Price => 0;
    [Ignore]
    public override double Quantity
    {
        get => BerBeholdning;
        set => BerBeholdning = value;
    }

    [Ignore]
    public override double Amount
    {
        get => AFREGNINGSBELØB;
        set => AFREGNINGSBELØB = value;
    }

    public override string ISIN => _isin;
    public override string TradeType => $"{RecType}, {AfkastType}";
    // Ignore first leading zero
    public override string Account => KONTONR[0] == '0' ? KONTONR[1..] : KONTONR;
    public override List<(string costType, double cost)> GetCosts()
    {
        return
        [
            (nameof(OMKOSTNING), OMKOSTNING),
            (nameof(OMKOSTNING), SKAT),
        ];
    }
}