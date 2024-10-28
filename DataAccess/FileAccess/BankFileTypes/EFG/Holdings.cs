using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Models;
using DataAccess.FileAccess.BankFileTypes.Jyske;
using Shared.Consts;
using Shared.Enums;

namespace DataAccess.FileAccess.BankFileTypes.EFG;

public interface IEFGType
{
    [Ignore]
    public MetaData metaData { get; set; }
}

public class Holdings : BankHolding, IEFGType
{
    public string EntityCod {get;set;}
    public string CustId {get;set;}
    public string PortfId {get;set;}
    public string PosId {get;set;}
    public string SystemIdCod {get;set;}
    public string SystemIdDsc {get;set;}
    public string PosHfmCod {get;set;}
    public string PosHfmDsc {get;set;}
    public string PosNameTxt {get;set;}
    public string PosValuationDat {get;set;}
    public string PosPriceAmt {get;set;}
    public string PosCcyCod {get;set;}
    public string PosPriceTypeCod {get;set;}
    public string PosPriceTypeDsc {get;set;}
    public string PosEstimAmt {get;set;}
    public string PosEstimRefAmt {get;set;}
    public string PosEstimRefCcyCod {get;set;}
    public string PosIntAccrAmt {get;set;}
    public string PosIntAccrRefAmt {get;set;}
    public string PosRefRateAmt {get;set;}
    [Default(0)]
    public decimal PosQuantityAmt {get;set;}
    public string PosOpenDate {get;set;}
    public string PosSecId {get;set;}
    public string PosSecIsin {get;set;}
    public string PosValorenId {get;set;}
    public string PosSubAssetTypeCod {get;set;}
    public string PosSubAssetTypeDsc {get;set;}
    public string PosPriceDat {get;set;}
    public string PosXrGroupCod {get;set;}
    public string PosXrGroupDsc {get;set;}
    public string PosContractSizeAmt {get;set;}
    public string PosIntRateAmt {get;set;}
    public string PosCostEstimAmt {get;set;}
    public string PosCostEstimRefAmt {get;set;}
    public string PosCostPriceAmt {get;set;}
    public string PosCostPriceRefAmt {get;set;}
    public string PosCostPriceRefRateAmt {get;set;}
    public string PosIntDaysNum {get;set;}
    public int PosAssetTypeCod {get;set;}
    public string PosAssetTypeDsc {get;set;}
    public string PosPriceCcyCod {get;set;}
    [Ignore]
    public string account { get; set; }
    [Ignore]
    public MetaData metaData { get; set; }
    public override DateTime HoldingDate => metaData.FromDate;
    public override string ISIN => PosSecIsin;
    public override decimal? Amount => PosQuantityAmt;
    public override decimal? Quantity => PosQuantityAmt;
    public override string Currency => PosCcyCod;
    // If it's a cash balance the PosSecId column holds the account name
    // Otherwise, we retrieve the account name via the depot and the currency
    public override string AccountName => account;
    public override HoldingType HoldingType
    {
        get
        {
            // TODO are these account cash, they have no isin
            // Misc funds accounts
            if (PosAssetTypeCod == 45) return HoldingType.Other;
            return SystemIdCod == "AC" ? HoldingType.Cash : HoldingType.Instrument;
        }
    }
}

public class MetaData
{
    public string ExtractionTime { get; set; }
    [Format(DateStringFormats.yyyydMMddd)]
    public DateTime FromDate { get; set; }
    [Format(DateStringFormats.yyyydMMddd)]
    public DateTime ToDate { get; set; }
    public int RowCount { get; set; }
}