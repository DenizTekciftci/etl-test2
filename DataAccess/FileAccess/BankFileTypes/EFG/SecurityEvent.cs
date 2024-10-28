using CsvHelper.Configuration.Attributes;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.EFG;

public class SecurityEvent : BankTransaction, IEFGType
{
        public string EntityCod { get; set; }
        public string PortfId { get; set; }
        public string DiaryId { get; set; }
        public string SystemIdCod { get; set; }
        public string SystemIdDsc { get; set; }
        public string ScEvId { get; set; }
        public string ScEvEvtTypeCod { get; set; }
        public string ScEvAuthorizeDat { get; set; }
        [Format(DateStringFormats.yyyydMMddd)] public DateTime ScEvValueDat { get; set; }
        [Format(DateStringFormats.yyyydMMddd)] public DateTime ScEvBookingDat { get; set; }
        public string ScEvCustodianId { get; set; }
        public string ScEvSecurityId { get; set; }
        public string ScEvSecIsin { get; set; }
        public string ScEvSecNominalAmt { get; set; }
        public string ScEvAccntId { get; set; }
        public string ScEvExDat { get; set; }
        public double ScEvNominalAmt { get; set; }
        public string ScEvNarrativeTxt { get; set; }
        public string ScEvCcyCod { get; set; }
        public double ScEvNetAmt { get; set; }
        public string ScEvAccCcyCod { get; set; }
        public string ScEvAccntNetAmt { get; set; }
        public string ScEvExchRateAmt { get; set; }
        public string ScEvDiaryRat { get; set; }
        public string ScEvRatPct { get; set; }
        public string ScEvGrossAmt { get; set; }
        public string ScEvTaxWithHeldAmt { get; set; }
        public string ScEvTaxWithHeldPct { get; set; }
        public string ScEvNominalAmtNew { get; set; }
        public string ScEvSecurityIdNew { get; set; }
        public string ScEvSecIsinNew { get; set; }
        public string ScEvIsReversedFlg { get; set; }
        public string ScEvSecRatio { get; set; }
        public string ScEvSecNewRatio { get; set; }
        public double ScEvLocalTaxAmt { get; set; }
        public string ScEvLocalTaxPct { get; set; }
        public string ScEvFgnChargesAmt { get; set; }
        public string ScEvNewExercisePriceAmt { get; set; }
        public override DateTime TradeDate => ScEvBookingDat;
        public override DateTime ValueDate => ScEvValueDat;
        public override string Currency => ScEvCcyCod;
        public override double Price { get; }

        [Ignore]
        public override double Quantity
        {
                get => ScEvNominalAmt;
                set => ScEvNominalAmt = value;
        }

        [Ignore]
        public override double Amount
        {
                get => ScEvNetAmt;
                set => ScEvNetAmt = value;
        }

        public override string ISIN => ScEvSecIsin;
        public override string TradeType => ScEvEvtTypeCod;
        public override string Account => ScEvAccntId;
        public override List<(string costType, double cost)> GetCosts()
        {
                return
                [
                        (nameof(ScEvLocalTaxAmt), ScEvLocalTaxAmt),
                ];
        }

        [Ignore] public MetaData metaData { get; set; }
}