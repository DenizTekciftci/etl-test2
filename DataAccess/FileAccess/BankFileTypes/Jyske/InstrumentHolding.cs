using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using Shared.Consts;
using Shared.Enums;

namespace DataAccess.FileAccess.BankFileTypes.Jyske;


public class InstrumentHolding : BankHolding
{
    public override DateTime HoldingDate => _holdingDate;
    public override string ISIN => _isin;

    public override decimal? Amount => KURSVAERDI;
    public override decimal? Quantity => BEHOLDNING;
    public override string Currency => _currency;
    // Remove first leading zero
    public override string AccountName => ReturnAccount[0] == '0' ? ReturnAccount[1..] : ReturnAccount;
    public override HoldingType HoldingType => HoldingType.Instrument;
    
    public string DEPOTNR {get; set;}
    public int FONDSKODE {get; set;}

    [Name("ISIN-KODE")]
    public string _isin {get; set;}

    [Name("PAPIRETS NAVN")]
    public string InstrumentName {get; set;}
    public string NOTERINGSKODE {get; set;}
    [Name("CPRNR/CVRNR/REFNR PÅ EJER")]
    public string Owner {get; set;}
    [Name("PAPIR VALUTA")]
    public string _currency {get; set;}

    public string VALUTAKURS {get; set;}
    public decimal KURSVAERDI {get; set;}
    [Name("INDEX-FAKTOR")]
    public string IndexFactor {get; set;}
    public decimal BEHOLDNING {get; set;}
    [Name("UDTRUKKET BELOEB")]
    public string WithdrawnBalance {get; set;}
    [Name("UAFVIKLEDE KØB")]
    public string UnfinishedPurchases {get; set;}
    [Name("UAFVIKLEDE SALG")]
    public string UnfinishedSales {get; set;}
    [Name("PAPIRETS KURS")]
    public string InstrumentPrice {get; set;}
    [Name("DATO FOR KURSEN")]
    public string DateOfPrice {get; set;}
    [Name("DATO FOR BEHOLDN.")]
    [Format(DateStringFormats.yyyydMMddd)]
    public DateTime _holdingDate {get; set;}
    [Name("AFKAST KONTONR.")]
    public string ReturnAccount {get; set;}
}