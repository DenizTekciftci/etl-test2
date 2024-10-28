using System.Globalization;
using System.Xml.Serialization;
using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;

namespace DataAccess.FileAccess.BankFileTypes.Nordnet;

[XmlRoot(ElementName="transaction")]
public class Transaction : BankTransaction
{
	public override DateTime TradeDate => AccountDate;
	public override DateTime ValueDate => _valueDate;
	public override string Currency => Curcode;
	public override double Price => _price;
	[Ignore]
	public override double Quantity
	{
		get => Qty;
		set => Qty = value;
	}

	[Ignore]
	public override double Amount
	{
		get => Amt;
		set => Amt = value;
	}

	public override string ISIN => Isincode;
	public override string TradeType => Trtshortname;
	public override string Account => Accno + Curcode;

	[XmlElement("exportdate")] // Name matches the XML node name
	public string ExportDateString { get; set; }

	// This is the property that converts the string to DateTime.
	[XmlIgnore]
	public DateTime Exportdate
	{
		get
		{
			return DateTime.ParseExact(ExportDateString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		}
		set
		{
			ExportDateString = value.ToString("yyyy-MM-dd HH:mm:ss");
		}
	}

	[XmlElement(ElementName="acsid")] 
	public int Acsid { get; set; } 
	
	[XmlElement(ElementName="price")] 
	public double _price { get; set; }

	[XmlElement(ElementName="accno")] 
	public string Accno { get; set; } 

	[XmlElement(ElementName="accountdate")] 
	public DateTime AccountDate { get; set; } 

	[XmlElement(ElementName="valuedate")] 
	public DateTime _valueDate { get; set; } 

	[XmlElement(ElementName="busdate")] 
	public DateTime Busdate { get; set; } 

	[XmlElement(ElementName="insid")] 
	public int Insid { get; set; } 

	[XmlElement(ElementName="isincode")] 
	public string Isincode { get; set; } 

	[XmlElement(ElementName="curcode")] 
	public string Curcode { get; set; } 

	[XmlElement(ElementName="searchname")] 
	public string Searchname { get; set; } 

	[XmlElement(ElementName="verno")] 
	public int Verno { get; set; } 

	[XmlElement(ElementName="contnoteno")] 
	public int Contnoteno { get; set; } 

	[XmlElement(ElementName="trtcode")] 
	public string Trtcode { get; set; } 

	[XmlElement(ElementName="ttgcode")] 
	public string Ttgcode { get; set; } 

	[XmlElement(ElementName="trtshortname")] 
	public string Trtshortname { get; set; } 

	[XmlElement(ElementName="qty")] 
	public double Qty { get; set; } 

	[XmlElement(ElementName="netprice")] 
	public double Netprice { get; set; }

	[XmlElement(ElementName="amt")] 
	public double Amt { get; set; } 
	
	[XmlElement(ElementName="totcharges")]
	public double Totcharges { get; set; } 

	[XmlElement(ElementName="avgtotacqcost")] 
	public double Avgtotacqcost { get; set; } 

	[XmlElement(ElementName="avgresult")] 
	public double Avgresult { get; set; } 

	[XmlElement(ElementName="curprice")] 
	public double Curprice { get; set; } 

	[XmlElement(ElementName="currency_pair")] 
	public string CurrencyPair { get; set; } 

	[XmlElement(ElementName="accounttext")] 
	public object Accounttext { get; set; }

	public override List<(string costType, double cost)> GetCosts()
	{
		return [("COMMISSIONS", Totcharges)];
	}
}

[XmlRoot(ElementName="result")]
public class TransactionsResult { 

	[XmlElement(ElementName="transaction")] 
	public List<Transaction> Transactions { get; set; } 
}