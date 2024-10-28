using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.Jyske;

public class CashTransaction : BankTransaction
{
    public override DateTime TradeDate => _tradeDate;
    public override DateTime ValueDate => _valueDate;
    public override string Currency => Mønt;
    public override double Price => 0;
    [Ignore]
    public override double Quantity
    {
        get => quantity;
        set => quantity = value;
    }

    [Ignore]
    public override double Amount
    {
        get => Beløb;
        set => Beløb = value;
    }

    public override string ISIN => "";
    public override string TradeType => TradeTypeName;
    public override string Account => AccountNumber[0] == '0' ? AccountNumber[1..] : AccountNumber;
    public override List<(string costType, double cost)> GetCosts()
    {
        // No costs
        return [];
    }
    
    public string GetTradeTypeName(IBank bank)
    {
        if (PostTekst == Consts.TilbageførselObligrationsrente) return $"{Type}, {PostTekst}";
        
        var tradeTypeSuffix = InOutTypes(bank)
            .Any(s => s.StartsWith(Type))
            ? Amount >= 0 ? Consts.InSuffix : Consts.OutSuffix
            : "";
        
        return Type + tradeTypeSuffix;
    }
    
    private List<string> InOutTypes(IBank bank)
    {
        return bank.GetTradeTypes().Select(tt => tt.BankTypeName)
            .Where(btn => btn.EndsWith(Consts.InSuffix) || btn.EndsWith(Consts.OutSuffix))
            .ToList();
    }
        
    [Ignore]
    public string TradeTypeName { get; set; }

    [Ignore] public double quantity { get; set; } = 0;

    [Name("Bank")]
    public string _bank {get;set;}
    [Name("Kontonr.")]
    public string AccountNumber {get;set;}
    [Name("Bogførings dato")]
    [Format(DateStringFormats.ddpMMpyyyy)]
    public DateTime _tradeDate {get;set;}
    [Name("Valør dato")]
    [Format(DateStringFormats.ddpMMpyyyy)]
    public DateTime _valueDate {get;set;}
    public string Mønt {get;set;}
    public double Beløb {get;set;}
    [Name("Post tekst")]
    public string PostTekst {get;set;}
    public string Type {get;set;}
    [Name("Udbetalings ref.")]
    public string UdbetalingsRef {get;set;}
    [Name("Adresse 1")]
    public string Address1 {get;set;}
    [Name("Adresse 2")]
    public string Address2 {get;set;}
    [Name("Adresse 3")]
    public string Address3 {get;set;}
    [Name("Adresse 4")]
    public string Address4 {get;set;}
    [Name("Adresse 5")]
    public string Address5 {get;set;}
    [Name("Adresse 6")]
    public string Address6 {get;set;}
    [Name("Adresse 7")]
    public string Addresse7 {get;set;}
    [Name("Adresse 8")]
    public string Address8 {get;set;}
    public string Gade {get;set;}
    [Name("Postnr.")]
    public string PostCode {get;set;}
    public string By {get;set;}
    public string Landekode {get;set;}
    [Name("Off. virksomheds nr.")]
    public string PublicBusinessNo {get;set;}
    [Name("Advisering  1")]
    public string Advisering1 {get;set;}
    [Name("Advisering  2")]
    public string Advisering2 {get;set;}
    [Name("Advisering  3")]
    public string Advisering3 {get;set;}
    [Name("Advisering  4")]
    public string Advisering4 {get;set;}
    [Name("Advisering  5")]
    public string Advisering5 {get;set;}
    [Name("Advisering  6")]
    public string Advisering6 {get;set;}
    [Name("Advisering  7")]
    public string Advisering7 {get;set;}
    [Name("Advisering  8")]
    public string Advisering8 {get;set;}
    [Name("Advisering  9")]
    public string Advisering9 {get;set;}
    [Name("Advisering 10")]
    public string Advisering10 {get;set;}
    [Name("Advisering 11")]
    public string Advisering11 {get;set;}
    [Name("Advisering 12")]
    public string Advisering12 {get;set;}
    [Name("Advisering 13")]
    public string Advisering13 {get;set;}
    [Name("Advisering 14")]
    public string Advisering14 {get;set;}
    [Name("Advisering 15")]
    public string Advisering15 {get;set;}
    [Name("Advisering 16")]
    public string Advisering16 {get;set;}
    [Name("Advisering 17")]
    public string Advisering17 {get;set;}
    [Name("Advisering 18")]
    public string Advisering18 {get;set;}
    [Name("Advisering 19")]
    public string Advisering19 {get;set;}
    [Name("Advisering 20")]
    public string Advisering20 {get;set;}
    [Name("Advisering 21")]
    public string Advisering21 {get;set;}
    [Name("Advisering 22")]
    public string Advisering22 {get;set;}
    [Name("Advisering 23")]
    public string Advisering23 {get;set;}
    [Name("Advisering 24")]
    public string Advisering24 {get;set;}
    [Name("Advisering 25")]
    public string Advisering25 {get;set;}
    [Name("Advisering 26")]
    public string Advisering26 {get;set;}
    [Name("Advisering 27")]
    public string Advisering27 {get;set;}
    [Name("Advisering 28")]
    public string Advisering28 {get;set;}
    [Name("Advisering 29")]
    public string Advisering29 {get;set;}
    [Name("Advisering 30")]
    public string Advisering30 {get;set;}
    [Name("Advisering 31")]
    public string Advisering31 {get;set;}
    [Name("Advisering 32")]
    public string Advisering32 {get;set;}
    [Name("Advisering 33")]
    public string Advisering33 {get;set;}
    [Name("Advisering 34")]
    public string Advisering34 {get;set;}
    [Name("Advisering 35")]
    public string Advisering35 {get;set;}
    [Name("Advisering 36")]
    public string Advisering36 {get;set;}
    [Name("Advisering 37")]
    public string Advisering37 {get;set;}
    [Name("Advisering 38")]
    public string Advisering38 {get;set;}
    [Name("Advisering 39")]
    public string Advisering39 {get;set;}
    [Name("Advisering 40")]
    public string Advisering40 {get;set;}
    [Name("Advisering 41")]
    public string Advisering41 {get;set;}
    [Name("Ref. type  1")]
    public string RefType1 {get;set;}
    [Name("Reference  01")]
    public string Reference01 {get;set;}
    [Name("Ref. type  2")]
    public string RefType2 {get;set;}
    [Name("Reference  02")]
    public string Reference02 {get;set;}
    [Name("Ref. type  3")]
    public string RefType3 {get;set;}
    [Name("Reference  03")]
    public string Reference03 {get;set;}
    [Name("Ref. type  4")]
    public string RefType4 {get;set;}
    [Name("Reference  04")]
    public string Reference04 {get;set;}
    [Name("Ref. type  5")]
    public string RefType5 {get;set;}
    [Name("Reference  05")]
    public string Reference05 {get;set;}
    [Name("Ref. type  6")]
    public string RefType6 {get;set;}
    [Name("Reference  06")]
    public string Reference06 {get;set;}
    [Name("Ref. type  7")]
    public string RefType7 {get;set;}
    [Name("Reference  07")]
    public string Reference07 {get;set;}
    [Name("Ref. type  8")]
    public string RefType8 {get;set;}
    [Name("Reference  08")]
    public string Reference08 {get;set;}
    [Name("Ref. type  9")]
    public string RefType9 {get;set;}
    [Name("Reference  09")]
    public string Reference09 {get;set;}
    [Name("Ref. type 10")]
    public string RefType10 {get;set;}
    [Name("Reference  10")]
    public string Reference10 {get;set;}
    [Name("Ref. type 11")]
    public string RefType11 {get;set;}
    [Name("Reference  11")]
    public string Reference11 {get;set;}
    [Name("Ref. type 12")]
    public string RefType12 {get;set;}
    [Name("Reference  12")]
    public string Reference12 {get;set;}
    [Name("Ref. type 13")]
    public string RefType13 {get;set;}
    [Name("Reference  13")]
    public string Reference13 {get;set;}
    [Name("Ref. type 14")]
    public string RefType14 {get;set;}
    [Name("Reference  14")]
    public string Reference14 {get;set;}
    [Name("Ref. type 15")]
    public string RefType15 {get;set;}
    [Name("Reference  15")]
    public string Reference15 {get;set;}
    [Name("Ref. type 16")]
    public string RefType16 {get;set;}
    [Name("Reference  16")]
    public string Reference16 {get;set;}
    [Name("Ref. type 17")]
    public string RefType17 {get;set;}
    [Name("Reference  17")]
    public string Reference17 {get;set;}
    [Name("Ref. type 18")]
    public string RefType18 {get;set;}
    [Name("Reference  18")]
    public string Reference18 {get;set;}
    [Name("Ref. type 19")]
    public string RefType19 {get;set;}
    [Name("Reference  19")]
    public string Reference19 {get;set;}
    [Name("Ref. type 20")]
    public string RefType20 {get;set;}
    [Name("Reference  20")]
    public string Reference20 {get;set;}
    [Name("Ref. type 21")]
    public string RefType21 {get;set;}
    [Name("Reference  21")]
    public string Reference21 {get;set;}
    [Name("Ref. type 22")]
    public string RefType22 {get;set;}
    [Name("Reference  22")]
    public string Reference22 {get;set;}
    [Name("Ref. type 23")]
    public string RefType23 {get;set;}
    [Name("Reference  23")]
    public string Reference23 {get;set;}
    [Name("Ref. type 24")]
    public string RefType24 {get;set;}
    [Name("Reference  24")]
    public string Reference24 {get;set;}
    [Name("Ref. type 25")]
    public string RefType25 {get;set;}
    [Name("Reference  25")]
    public string Reference25 {get;set;}
    [Name("Ref. type 26")]
    public string RefType26 {get;set;}
    [Name("Reference  26")]
    public string Reference26 {get;set;}
    [Name("Ref. type 27")]
    public string RefType27 {get;set;}
    [Name("Reference  27")]
    public string Reference27 {get;set;}
    [Name("Ref. type 28")]
    public string RefType28 {get;set;}
    [Name("Reference  28")]
    public string Reference28 {get;set;}
    [Name("Ref. type 29")]
    public string RefType29 {get;set;}
    [Name("Reference  29")]
    public string Reference29 {get;set;}
    [Name("Ref. type 30")]
    public string RefType30 {get;set;}
    [Name("Reference  30")]
    public string Reference30 {get;set;}
    [Name("Ref. type 31")]
    public string RefType31 {get;set;}
    [Name("Reference  31")]
    public string Reference31 {get;set;}
    [Name("Ref. type 32")]
    public string RefType32 {get;set;}
    [Name("Reference  32")]
    public string Reference32 {get;set;}
    [Name("Ref. type 33")]
    public string RefType33 {get;set;}
    [Name("Reference  33")]
    public string Reference33 {get;set;}
    [Name("Ref. type 34")]
    public string RefType34 {get;set;}
    [Name("Reference  34")]
    public string Reference34 {get;set;}
    [Name("Ref. type 35")]
    public string RefType35 {get;set;}
    [Name("Reference  35")]
    public string Reference35 {get;set;}
    [Name("Ref. type 36")]
    public string RefType36 {get;set;}
    [Name("Reference  36")]
    public string Reference36 {get;set;}
    [Name("Ref. type 37")]
    public string RefType37 {get;set;}
    [Name("Reference  37")]
    public string Reference37 {get;set;}
    [Name("Ref. type 38")]
    public string RefType38 {get;set;}
    [Name("Reference  38")]
    public string Reference38 {get;set;}
    [Name("Ref. type 39")]
    public string RefType39 {get;set;}
    [Name("Reference  39")]
    public string Reference39 {get;set;}
    [Name("Ref. type 40")]
    public string RefType40 {get;set;}
    [Name("Reference  40")]
    public string Reference40 {get;set;}
    [Name("Ref. type 41")]
    public string RefType41 {get;set;}
    [Name("Reference  41")]
    public string Reference41 {get;set;}
    [Name("Jyske Bank lev. nr.")]
    public string JyskeBankLevNumber {get;set;}                                   
}