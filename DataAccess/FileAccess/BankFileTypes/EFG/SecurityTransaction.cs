using CsvHelper.Configuration.Attributes;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.EFG;

public class SecurityTransaction : BankTransaction, IEFGType 
{
    public string EntityCod { get; set; }
    public string PortfId { get; set; }
    public string CustId { get; set; }
    public string ScTrOrderId { get; set; }
    public string ScTrId { get; set; }
    public string SystemIdCod { get; set; }
    public string SystemIdDsc { get; set; }
    public string ScTrTransCodeCod { get; set; }
    public string ScTrTransCodeDsc { get; set; }
    public string ScTrBookingDat { get; set; }
    [Format(DateStringFormats.yyyydMMddd)]
    public DateTime ScTrTradeDat { get; set; }
    [Format(DateStringFormats.yyyydMMddd)]
    public DateTime ScTrValueDat { get; set; }
    public string ScTrExtRefTxt { get; set; }
    public string ScTrAccntId { get; set; }
    public string ScTrSecurityId { get; set; }
    public string ScTrStockExchangeCod { get; set; }
    public string ScTrTradeCcyCod { get; set; }
    public double ScTrNominalAmt { get; set; }
    public double ScTrCustPriceAmt { get; set; }
    public string ScTrAccntNetAmt { get; set; }
    public string ScTrCustAccntRateAmt { get; set; }
    public string ScTrAdviceRemarkTxt { get; set; }
    public string ScTrGrossAmt { get; set; }
    public double ScTrNetAmt { get; set; }
    public double ScTrCommAmt { get; set; }
    public double ScTrCommBrokerAmt { get; set; }
    public string ScTrInterestAmt { get; set; }
    public double ScTrFeesMiscAmt { get; set; }
    public string ScTrFeesEbvAmt { get; set; }
    public double ScTrFeesForeignAmt { get; set; }
    public double ScTrTaxStampAmt { get; set; }
    public double ScTrTaxEuAmt { get; set; }
    public double ScTrTaxCommAmt { get; set; }
    public string ScTrLimitPriceCod { get; set; }
    public string ScTrLimitPrice { get; set; }
    public string ScTrAccntCcyCod { get; set; }
    public string ScTrIntDaysBasisCod { get; set; }
    public string ScTrInteresDaysAmt { get; set; }
    public string ScTrCpartyTxt { get; set; }
    public string ScTrSecIsin { get; set; }
    public string ScTrIsReversedFlg { get; set; }
    public string ScTrReversalDat { get; set; }
    public string ScTrExternalOrderRef { get; set; }
    public string ScTrDxLinkReferenceTxt { get; set; }
    [Format("dd.MM.yyyy HH:mm:ss")]
    public DateTime ScTrExecutionDtm { get; set; }
    [Ignore]
    public MetaData metaData { get; set; }
    public override DateTime TradeDate => ScTrTradeDat;
    public override DateTime ValueDate => ScTrValueDat;
    public override string Currency => ScTrTradeCcyCod;
    public override double Price => ScTrCustPriceAmt;
    [Ignore]
    public override double Quantity
    {
        get => ScTrNominalAmt;
        set => ScTrNominalAmt = value;
    }

    [Ignore]
    public override double Amount
    {
        get => ScTrNetAmt;
        set => ScTrNetAmt = value;
    }

    public override string ISIN => ScTrSecIsin;
    public override string TradeType => ScTrTransCodeCod;
    public override string Account => ScTrAccntId;
    public override List<(string costType, double cost)> GetCosts()
    {
        return
        [
            (nameof(ScTrCommAmt), ScTrCommAmt),
            (nameof(ScTrCommBrokerAmt), ScTrCommBrokerAmt),
            (nameof(ScTrFeesMiscAmt), ScTrFeesMiscAmt),
            (nameof(ScTrFeesForeignAmt), ScTrFeesForeignAmt),
            (nameof(ScTrTaxStampAmt), ScTrTaxStampAmt),
            (nameof(ScTrTaxEuAmt), ScTrTaxEuAmt),
            (nameof(ScTrTaxCommAmt), ScTrTaxCommAmt),
        ];
    }
}