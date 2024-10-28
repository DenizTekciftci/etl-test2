using CsvHelper.Configuration.Attributes;
using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Enums;
using DataAccess.DatabaseAccess.Infrastructure;
using DataAccess.DatabaseAccess.Models;
using Shared.Consts;

namespace DataAccess.FileAccess.BankFileTypes.Saxo;

public class BookkeepingCash : BankTransaction
{
    public override string TradeType => TradeTypeName;
    public override string Account => AccountNumber;
    public override double Price => 0;
    [Ignore]
    public override double Quantity { get; set; }
    [Ignore]
    public override double Amount
    {
        get => AmountAccountCurrency == 0 ? BookedAmount : AmountAccountCurrency;
        set => AmountAccountCurrency = value;
    }

    public override string ISIN => "";
    public override DateTime TradeDate => _tradeDate;
    public override DateTime ValueDate => _valueDate;
    public override string Currency => BookedAmountCurrency;
    [Ignore]
    public string TradeTypeName { get; set; }
    [Name("TradeDate")]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime _tradeDate { get; set; }
    [Name("ValueDate")]
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime _valueDate { get; set; }
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime ReportingDate { get; set;}
    public string InstrumentType { get; set;}
    public string CounterpartID { get; set;}
    public string AccountNumber { get; set;}
    public string PartnerAccountKey { get; set;}
    public string AccountCurrency { get; set;}
    public string InstrumentCode { get; set;}
    public string BookedAmountCurrency { get; set;}
    public double BookedAmount { get; set;}
    public string BkAmountID { get; set;}
    public string RelatedPositionID { get; set;}
    public string RelatedTradeID { get; set;}
    public string OrderNumber { get; set;}
    public string BkAmountTypeID { get; set;}
    public string BkAmountType { get; set;}
    [Format(DateStringFormats.yyyyMMdd)]
    public double AmountAccountCurrency { get; set;}
    public string BookedAmountToAccountRate { get; set;}
    public string OriginalTradeID { get; set;}
    public string CorrectionLeg { get; set;}
    public string CAEventTypeID { get; set;}
    public string CAEventTypeName { get; set;}
    public string AdhocBookingCodeID { get; set;}
    public string AdhocBookingCode { get; set;}
    public string InstrumentUIC { get; set;}
    [Format(DateStringFormats.yyyyMMdd)]
    public DateTime ActualTradeDate { get; set;}
    public string CAEventID { get; set;}
    public string AmountBaseCurrency { get; set;}
    public string AmountAccountCurrencyWithoutMarkup { get; set;}
    public string FeemsProfileName { get; set;}

    private List<string> InOutTypes(IBank bank)
    {
        return bank.GetTradeTypes().Select(tt => tt.BankTypeName)
            .Where(btn => btn.EndsWith(Consts.InSuffix) || btn.EndsWith(Consts.OutSuffix))
            .ToList();
    }
    
    public string GetTradeTypeName(IBank bank)
    {
        var inOutTypes = InOutTypes(bank);
        var tradeTypeSuffix = inOutTypes
            .Any(s => s.StartsWith(BkAmountType))
            ? BookedAmount >= 0 ? Consts.InSuffix : Consts.OutSuffix
            : "";
        
        return BkAmountType + tradeTypeSuffix;
    }

    public TransactionTables GetDexTableId(IBank bank)
    {
        var tradeType = GetTradeTypeName(bank);
        return bank.GetTransactionTableFromTradeType(tradeType);  
    }
    
    public override List<(string costType, double cost)> GetCosts()
    {
        // No costs in bookkeeping
        return [];
    }
}