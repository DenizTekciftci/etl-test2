using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.EFG;

public class AccountOther: BankTransaction, IEFGType
{ 
    public string EntityCod {get;set;}
    public string CustId {get;set;}
    public string PortfId {get;set;}
    public string StmtId {get;set;}
    public string SystemIdCod {get;set;}
    public string SystemIdDsc {get;set;}
    public string StmtTransCod {get;set;}
    public string StmtTransDsc {get;set;}
    [Format(DateStringFormats.yyyydMMddd)]
    public DateTime StmtBookingDat {get;set;}
    [Format(DateStringFormats.yyyydMMddd)]
    public DateTime StmtValueDat {get;set;}
    public string StmtOurReferenceTxt {get;set;}
    public double StmtAccntAmt {get;set;}
    public string StmtAccntId {get;set;}
    public string StmtAccntCcyCod {get;set;}
    public string StmtNarrativeDsc {get;set;}
    public string StmtIsReversedFlg {get;set;}
    public string StmtFeesTypeCod {get;set;}
    public override DateTime TradeDate => StmtBookingDat;
    public override DateTime ValueDate => StmtValueDat;
    public override string Currency => StmtAccntCcyCod;
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
        get => StmtAccntAmt;
        set => StmtAccntAmt = value;
    }

    public override string ISIN => "";
    public override string TradeType => TradeTypeName;
    public override string Account => StmtAccntId;
    public override List<(string costType, double cost)> GetCosts()
    {
        return [];
    }
    [Ignore]
    public MetaData metaData { get; set; }
    [Ignore]
    public string TradeTypeName { get; set; }

    [Ignore] public double quantity { get; set; } = 0;
    public string GetTradeTypeName(IBank bank)
    {
        var types = InOutTypes(bank).ToList();
        var tradeTypeSuffix = InOutTypes(bank)
            .Any(s => s.StartsWith(StmtTransDsc))
            ? Amount >= 0 ? Consts.InSuffix.ToUpper() : Consts.OutSuffix.ToUpper()
            : "";
        
        return StmtTransDsc + tradeTypeSuffix;
    }
    
    private List<string> InOutTypes(IBank bank)
    {
        return bank.GetTradeTypes().Select(tt => tt.BankTypeName)
            .Where(btn => btn.EndsWith(Consts.InSuffix.ToUpper()) || btn.EndsWith(Consts.OutSuffix.ToUpper()))
            .ToList();
    }
}