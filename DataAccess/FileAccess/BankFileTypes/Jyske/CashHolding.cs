using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using Shared.Consts;
using Shared.Enums;

namespace DataAccess.FileAccess.BankFileTypes.Jyske;

public class CashHolding : BankHolding
{
    public override DateTime HoldingDate => _holdingDate;
    public override string ISIN => "";
    public override decimal? Amount => Balance;
    public override decimal? Quantity => null;
    public override string Currency => _currency;
    public override string AccountName => Account[0] == '0' ? Account[1..] : Account;
    public override HoldingType HoldingType => HoldingType.Cash;
    
    [Name("KONTOEJER")]
    public string AccountOwner {get;set;}
    [Name("SENR-CPR")]
    public string Cpr {get;set;}
    [Name("KONTONUMMER")]
    public string Account {get;set;}
    [Name("TYPE")]
    public string AccountType {get;set;}
    [Name("NAVN")]
    public string Name {get;set;}
    [Name("VALUTA")]
    public string _currency {get;set;}
    [Name("SALDO")]
    public decimal Balance {get;set;}
    [Name("MAXIMUM")]
    public string Max {get;set;}
    [Name("SALDO INKL. MAXIMUM")]
    public string BalanceInclMax {get;set;}
    [Name("SALDO I DKK")]
    public string BalanceDKK {get;set;}
    [Name("SALDO INKL. MAXIMUM I DKK")]
    public string  BalanceInclMaxDKK {get;set;}
    [Format(DateStringFormats.yyyydMMddd)]
    [Name("DATO FOR UDTRÆK")]
    public DateTime _holdingDate {get;set;}
    [Name("DATO FOR SENESTE BEVÆGELSE")]
    public string LastTransactionDate {get;set;}
    [Name("BIC-ADRESSE")]
    public string  BICAddress {get;set;}
    [Name("VEDH. RENTE")]
    public string RemainingInterest {get;set;}
}