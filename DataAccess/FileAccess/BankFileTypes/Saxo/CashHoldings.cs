using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using Shared.Consts;
using Shared.Enums;

namespace DataAccess.FileAccess.BankFileTypes.Saxo;

public class CashHoldings : BankHolding
{
    public string Account { get; set;}
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime Date { get; set;}
    public string AccountCurrency { get; set;}
    public decimal Balance { get; set;}
    public string OpenPositionsFX { get; set;}
    public string OpenPositionsFXOptions { get; set;}
    public string OpenPositionsStock { get; set;}
    public string OpenPositionsCFD { get; set;}
    public string OpenPositionsCFDOption { get; set;}
    public string OpenPositionsFutures { get; set;}
    public string OpenPositionsETO { get; set;}
    public string OpenPositionsMutualFunds { get; set;}
    public string OpenPositionsBonds { get; set;}
    public string OpenpositionsCash { get; set;}
    public string ActiveAccount { get; set;}
    public string PendingNonMarginPositions { get; set;}
    public string TotalEquity { get; set;}
    public string AccountFunding { get; set;}
    public string ReservedForFutureUse2 { get; set;}
    public string PartnerAccountKey { get; set;}
    public string ValueDateCashBalance { get; set;}
    public string RiskGroupProfile { get; set;}
    public string AccountRiskProfile { get; set;}
    public string AccountLevelMargining { get; set;}
    public string CounterpartID { get; set;}
    public string OwnerID { get; set;}
    public string IsClientAccount { get; set;}
    public string AccountType { get; set;}
    public string AccountSubType { get; set;}
    public string OpenPositionsSP { get; set;}
    public string OpenPositionsStockWithSRDFeature { get; set;}
    public string OpenPositionsFXClientRate { get; set;}
    public string OpenPositionsFXOptionsClientRate { get; set;}
    public string OpenPositionsStockClientRate { get; set;}
    public string OpenPositionsCFDClientRate { get; set;}
    public string OpenPositionsCFDOptionClientRate { get; set;}
    public string OpenPositionsFuturesClientRate { get; set;}
    public string OpenPositionsETOClientRate { get; set;}
    public string OpenPositionsMutualFundsClientRate { get; set;}
    public string OpenPositionsBondsClientRate { get; set;}
    public string OpenpositionsCashClientRate { get; set;}
    public string TotalEquityClientRate { get; set;}
    public string TotalAccruals { get; set;}
    public string CAAccruals { get; set;}
    public string FinancingAccruals { get; set;}
    public override DateTime HoldingDate => Date;
    public override string ISIN => "";

    public override decimal? Amount => Balance;
    public override decimal? Quantity => null;
    public override string Currency => AccountCurrency;
    public override string AccountName => Account;
    public override HoldingType HoldingType => HoldingType.Cash;
}