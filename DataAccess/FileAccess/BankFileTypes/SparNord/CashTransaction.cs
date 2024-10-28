using CsvHelper.Configuration.Attributes;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.SparNord;

public class CashTransaction: BankTransaction
{
    [Index(0)]
    public string RECORD_TYPE { get; set;}
    [Index(1)]
    public string _account { get; set;}
    [Index(2)]
    public string TRANSACTION_NUMBER { get; set;}
    [Index(3)]
    public string LINK_TRANSACTION_NUMBER { get; set;}
    [Index(4)]
    public string TEMP_TRADE_TYPE_NAME_2 { get; set;}
    [Index(5)]
    public int _tradeType { get; set;}
    [Index(6)]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime _tradeDate { get; set;}
    [Index(7)]
    public string COMMENT { get; set;}
    [Index(8)]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime _valueDate { get; set;}
    [Index(9)]
    public string AMOUNT_DKK { get; set;}
    [Index(10)]
    public string REGISTRATION_TYPE { get; set;}
    [Index(11)]
    public double _amount { get; set;}
    [Index(12)]
    public string _currency { get; set;}
    public override DateTime TradeDate => _tradeDate;
    public override DateTime ValueDate => _valueDate;
    public override string Currency => _currency;
    public override double Price => 0;
    [Ignore]
    public override double Quantity { get; set; }

    [Ignore]
    public override double Amount
    {
        get => _amount;
        set => _amount = value;
    }

    public override string ISIN => "";
    public override string TradeType => GetTradeTypeFromNumber(_tradeType);
    public override string Account => _account;
    public override List<(string costType, double cost)> GetCosts()
    {
        // No costs
        return [];
    }

    private string GetTradeTypeFromNumber(int tradeType)
    {
        return tradeType switch
        {
            6 => "CASH_TRANSFER",
            7 => "CASH_TRANSFER",
            159 => "CASH_TRANSFER",
            161 => "CASH_TRANSFER",
            207 => "CASH_TRANSFER",
            255 => "CASH_TRANSFER",
            279 => "CASH_TRANSFER",
            412 => "CASH_TRANSFER",
            500 => "CASH_TRANSFER",
            801 => "CASH_TRANSFER",
            803 => "CASH_TRANSFER",
            807 => "CASH_TRANSFER",
            100 => Consts.Ignore,
            101 => Consts.Ignore,
            105 => Consts.Ignore,
            113 => Consts.Ignore,
            114 => Consts.Ignore,
            117 => Consts.Ignore,
            118 => Consts.Ignore,
            44 => "Account interest",
            45 => "Account interest",
            164 => "Account interest",
            631 => "Depot fee",
            634 => "Depot fee",
            654 => "Depot fee",
            659 => "Depot fee",
            706 => "Depot fee",
            707 => "Depot fee",
            46 => "PROVISION",
            _ => ""
        };
    }

    // WTF_TRANSACTION_TYPE_DICT = {
    //     61219 => "FONDS",
    //     61228 => "Account interest",
    //     61239 => "SKAT",
    //     61241 => "ARBITRAGE",
    //     61278 => "UDTRUKNE OBLIGATIONER",
    //     61349 => "INDBETALING",
    //     61354 => "UDBYTTE",
    //     61382 => "OVERFØRSEL",
    //     61502 => "RENTE AF OBLIGATIONER",
    //     61503 => "Depot fee",
    //     61636 => "DIVERSE BETALING",
    //     70196651 => "UKENDT",
    //     70196652 => "CO-AKTION DIVERSE",
    //     70304478 => "INTERN KONTO-OVERFØRSEL",
    // }
}