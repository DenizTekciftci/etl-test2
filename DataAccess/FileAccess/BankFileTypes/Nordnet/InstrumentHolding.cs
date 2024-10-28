using System.Globalization;
using System.Xml.Serialization;
using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using Shared.Enums;

namespace DataAccess.FileAccess.BankFileTypes.Nordnet;

[XmlRoot(ElementName="position")]
public class InstrumentHolding : BankHolding
{ 

    [XmlElement("exportdate")] // Name matches the XML node name
    public string ExportDateString { get; set; }

    // This is the property that converts the string to DateTime.
    [XmlIgnore]
    public DateTime Exportdate
    {
        get
        {
            // Subtract 1 day from holdings in Nordnet
            return DateTime.ParseExact(ExportDateString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture).AddDays(-1);
        }
        set
        {
            ExportDateString = value.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }

    [XmlElement(ElementName="accno")] 
    public int Accno { get; set; } 

    [XmlElement(ElementName="insprice")]
    public string Insprice { get; set; } 

    [XmlElement(ElementName="inspricecurcode")] 
    public string Inspricecurcode { get; set; } 

    [XmlElement(ElementName="factor")] 
    public string Factor { get; set; } 

    [XmlElement(ElementName="inscalcprice")] 
    public string Inscalcprice { get; set; } 

    [XmlElement(ElementName="curcode")] 
    public string Curcode { get; set; } 

    [XmlElement(ElementName="insid")] 
    [Default(0)]
    public int Insid { get; set; } 

    [XmlElement(ElementName="isincode")] 
    public string Isincode { get; set; } 

    [XmlElement(ElementName="sumqty")] 
    public decimal Sumqty { get; set; } 

    [XmlElement(ElementName="marketvalue")] 
    public string Marketvalue { get; set; } 

    [XmlElement(ElementName="acqcost")] 
    public string Acqcost { get; set; } 

    [XmlElement(ElementName="acqcostacc")]
    public string Acqcostacc { get; set; }

    public override DateTime HoldingDate => Exportdate;
    public override string ISIN => Isincode;
    public override decimal? Amount => null;
    public override decimal? Quantity => Sumqty;
    public override string Currency => Curcode;
    public override string AccountName => Accno + Curcode;
    public override HoldingType HoldingType => HoldingType.Instrument;
}

[XmlRoot(ElementName="result")]
public class InstrumentHoldingsResult { 

    [XmlElement(ElementName="position")] 
    public List<InstrumentHolding> InstrumentHoldings { get; set; } 
}

