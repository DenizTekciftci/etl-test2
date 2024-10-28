using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;

namespace DataAccess.FileAccess.BankFileTypes.Jyske;

// TODO make usable
public class Transfers : BankTransaction
{
    [Name("REC-TYPE")]
    public string RecType {get; set;}
    [Name("DEPOTNR-FRA")]
    public string DepotFrom {get; set;}
    [Name("DEPOTNR-TIL")]
    public string DepotTo {get; set;}
    public int FONDSKODE {get; set;}
    public string ORDRENR {get; set;}
    public string TRANSTYPE {get; set;}
    public DateTime FLYTTEDATO {get; set;}
    [Name("DATO-VAL")]
    public DateTime _valueDate {get; set;}
    public double STKNOM {get; set;}
    [Ignore]
    public string? Isin {get; set;} 
    public override DateTime TradeDate => FLYTTEDATO;
    public override DateTime ValueDate => _valueDate;
    public override string Currency { get; }
    public override double Price => 0;
    [Ignore]
    public override double Quantity
    {
        get => STKNOM;
        set => STKNOM = value;
    }

    [Ignore]
    public override double Amount
    {
        get => amount;
        set => amount = value;
    }

    public override string ISIN => Isin ?? string.Empty;
    public override string TradeType => $"{RecType}, {TRANSTYPE}";
    public override string Account => DepotTo;
    public override List<(string costType, double cost)> GetCosts()
    {
        throw new NotImplementedException();
    }

    [Ignore] public double amount = 0;
}