using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Enums;
using DataAccess.DatabaseAccess.Infrastructure;
using DataAccess.DatabaseAccess.Models;

namespace Tests.Mock;

public class MockBank : IBank
{
    public int GetBankCostId(string tradeTypeName)
    {
        return 0;
    }

    public int GetBankId()
    {
        return 0;
    }

    public List<ITradeType> GetTradeTypes()
    {
        return new List<ITradeType>
        {
            GetTradeType("")
        };
    }

    public List<EomReturnDate> GetEomReturnDates()
    {
        return new List<EomReturnDate>();
    }

    public ITradeType GetTradeType(string tradeTypeName)
    {
        return new DexTradeTypeBil
        {
            Id = 0,
            BankTypeName = "TEST",
            TradeTypeId = 0,
            QuantityFactor = 1,
            AmountFactor = 1,
            GrossFactor = 1,
            CostsFactor = 1,
            NominalImpact = 1,
            CashImpact = 1,
        };
    }

    public TransactionTables GetTransactionTableFromTradeType(string tradeType)
    {
        var rnd = new Random();
        return (TransactionTables)rnd.Next(Enum.GetNames(typeof(TransactionTables)).Length);
    }

    public string GetAccountNameFromDepotNameAndCurrency(string depot, string currency)
    {
        return "TESTACCOUNTNAME";
    }

    public string GetISINFromFundCode(int fundCode)
    {
        return "TESTISIN";
    }

    public List<DexFundCode> GetFundCodes()
    {
        return new List<DexFundCode>
        {
            new DexFundCode
            {
                FundCode = 0,
                InstrumentId = 0,
                Isin = "TESTISIN",
            }
        };
    }

    public DexInstrument GetInstrumentFromIsin(string isin)
    {
        return new DexInstrument();
    }
}