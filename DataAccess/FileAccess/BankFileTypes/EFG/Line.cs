using CsvHelper.Configuration.Attributes;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.EFG;

public class Line : BankTransaction, IEFGType
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
        public string StmtLdOpenDat {get;set;}
        public string StmtLdCloseDat {get;set;}
        public string StmtLdDurationAmt {get;set;}
        public string StmtLdId {get;set;}
        public double StmtAccntAmt {get;set;}
        public string StmtAccntId {get;set;}
        public string StmtAccntCcyCod {get;set;}
        public string StmtNarrativeDsc {get;set;}
        public string StmtIsReversedFlg {get;set;}
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
        public override string TradeType => StmtTransDsc;
        public override string Account => StmtAccntId;
        public override List<(string costType, double cost)> GetCosts()
        {
                return [];
        }
        [Ignore]
        public MetaData metaData { get; set; }

        [Ignore] public double quantity { get; set; } = 0;
}