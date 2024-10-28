using CsvHelper.Configuration.Attributes;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.RILBA;

// TODO make usable
public class CashTransaction : BankTransaction
{
    public override DateTime TradeDate => _tradeDate;
    public override DateTime ValueDate => _valueDate;
    public override string Currency => _currency;
    [Ignore]
    public override double Amount
    {
        get => _amount;
        set => _amount = value;
    }

    public override string ISIN => "";
    public override string TradeType => "";
    public override string Account => AccountNumber;
    public override List<(string costType, double cost)> GetCosts()
    {
        // TODO
        throw new NotImplementedException();
    }
    
    public override double Price { get; }
    [Ignore]
    public override double Quantity { get; set; }

    [Name("-----")]
    public string Id {get; set;}
    [Name("Løbenr")]
    public string Løbenr {get; set;}
    [Name("Kontotype")]
    public string AccountType {get; set;}
    [Name("Kontonummer")]
    public string AccountNumber {get; set;}
    [Name("Bogføringsdato")]
    [Format(DateStringFormats.dddMMdyyyy)]
    public DateTime _tradeDate {get; set;}
    [Name("Valørdato")]
    [Format(DateStringFormats.dddMMdyyyy)]
    public DateTime _valueDate {get; set;}
    [Name("Posteringstekst")]
    public string PostText {get; set;}
    [Name("Mønt")]
    public string _currency {get; set;}
    [Name("Beløb")]
    public double _amount {get; set;}

    [Index(9)]
    public string Unknown1 {get; set;}
    [Name("Saldo")]
    public string Balance {get; set;}
    [Index(11)]
    public string Unknown2 {get; set;}
    [Name("Egen bilagsreference")]
    public string OwnReference {get; set;}
    [Name("Afs.opl.")]
    public string Unknown3 {get; set;}
    [Name("Afsenderopl. 1")]
    public string SendeInfo1 {get; set;}
    [Name("Afsenderopl. 2")]
    public string SendeInfo2 {get; set;}
    [Name("Afsenderopl. 3")]
    public string SendeInfo3 {get; set;}
    [Name("Afsenderopl. 4")]
    public string SendeInfo4 {get; set;}
    [Name("Afsenderopl. 5")]
    public string SendeInfo5 {get; set;}
    [Name("Kreditors ID")]
    public string CreditorID {get; set;}
    [Name("Reference")]
    public string Reference {get; set;}
    [Name("Debitors ID")]
    public string DebitorID {get; set;}
    [Name("Posterings-ID")]
    public string PostID {get; set;}
    [Name("BS Aftalenr")]
    public string PaymentServiceNumber {get; set;}
    [Index(24)]
    public string Unknown4 {get; set;}
    [Name("Vekslingsbeløb")]
    public string ExchangedAmount {get; set;}
    [Name("Vekslingskurs")]
    public string ExchangeRate {get; set;}
    [Name("Vekslingsgebyr")]
    public string ExchangeFee {get; set;}
    [Name("Oprindelig mønt")]
    public string InitialCurrency {get; set;}
    [Name("Oprindelig beløb")]
    public string InitialAmount {get; set;}
    [Name("Oprindelig kurs")]
    public string InitialExchangeRate {get; set;}
    [Name("End to end ref.")]
    public string EndToEndReference {get; set;}
    [Name("Kreditors ref.")]
    public string CreditorRef {get; set;}
    [Index(33)]
    public string Unknown5 {get; set;}
    [Name("Meddelelslinier")]
    public string Message {get; set;}
}       