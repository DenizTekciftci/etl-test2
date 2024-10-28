using System.Globalization;
using System.Xml.Serialization;
using DataAccess.DatabaseAccess.Banks;
using DataAccess.FileAccess.BankFileTypes;
using Shared.Enums;

[XmlRoot(ElementName="portfolio")]
public class Portfolio : BankHolding {
    
    public override DateTime HoldingDate => Exportdate;
    public override string ISIN => "";

    public override decimal? Amount => Accountsum;
    public override decimal? Quantity => null;
    public override string Currency => Curcode;
    public override string AccountName => Accno + Curcode;
    public override HoldingType HoldingType => HoldingType.Cash;

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

    [XmlElement(ElementName="curcode")] 
    public string Curcode { get; set; } 

    [XmlElement(ElementName="accountsum")] 
    public decimal Accountsum { get; set; } 

    [XmlElement(ElementName="accintcred")] 
    public double Accintcred { get; set; } 

    [XmlElement(ElementName="accintdeb")] 
    public double Accintdeb { get; set; }

}

[XmlRoot(ElementName="result")]
public class CashHoldingsResult { 

    [XmlElement(ElementName="portfolio")] 
    public List<Portfolio> Portfolio { get; set; } 
}