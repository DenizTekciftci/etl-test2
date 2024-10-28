using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Infrastructure;
using DataAccess.DatabaseAccess.Models;
using DataAccess.DatabaseAccess.Repositories;
using DataAccess.FileAccess.BankFileTypes;

namespace DataAccess.DatabaseAccess.Transformers;

public class CostTransformer(IAccountHelper accountHelper, IBank bank)
{
    public List<DexCost> CreateAllCosts(BankTransaction bankTransaction)
    {
        return bankTransaction.GetCosts().Select(costTypeAndAmount =>
        {
            if (costTypeAndAmount.cost == 0) return null;
            // Costs created with a transaction have 0 cash impact 
            return CreateCost
            (
                bankTransaction,
                costTypeAndAmount.costType,
                costTypeAndAmount.cost,
                0
            );
        }).Where(c => c != null).ToList()!;
    }
    
    public DexCost CreateCost(BankTransaction transaction, string costType, double costAmount, int? cashImpact = null)
    {

        ITradeType? tradeType = null;
        try
        {
            tradeType = bank.GetTradeType(costType);
        }
        catch
        {
            Console.WriteLine($"No trade type found for: {costType}, falling back to default cost type.");
        }

        return new DexCost
        {
            AccountId = accountHelper.GetAccountId(transaction.Account, transaction.Currency, bank.GetBankId()),
            TradeTypeId = tradeType?.TradeTypeId ?? 8,
            InputDate = DateTime.Today,
            TradeDate = transaction.TradeDate,
            ValueDate = transaction.ValueDate,
            Currency = transaction.Currency,
            Amount = costAmount * (tradeType?.AmountFactor ?? 1),
            BankCostId = bank.GetBankCostId(costType),
            DexTableId = (int)bank.GetTransactionTableFromTradeType(transaction.TradeType),
            PpTransaction = 1,
            CashImpact = cashImpact ?? tradeType?.CashImpact ?? 1
        };
    }
    
    public List<DexStagingCost> CreateAllStagingCosts(BankTransaction bankTransaction, string tableRef)
    {
        return bankTransaction.GetCosts().Select(costTypeAndAmount =>
        {
            if (costTypeAndAmount.cost == 0) return null;
            return CreateStagingCost
            (
                bankTransaction,
                costTypeAndAmount.costType,
                costTypeAndAmount.cost,
                tableRef
            );
        }).Where(c => c != null).ToList()!;
    }
    
    private DexStagingCost CreateStagingCost(BankTransaction transaction, string costType, double costAmount, string tableRef)
    {

        ITradeType? tradeType = null;
        int? accountId;
        try
        {
            tradeType = bank.GetTradeType(costType);
        }
        catch
        {
            Console.WriteLine($"No trade type found for: {costType}, falling back to default cost type.");
        }
        
        try
        {
            accountId = accountHelper.GetAccountId(transaction.Account, transaction.Currency,
                bank.GetBankId());
        }
        catch
        {
            accountId = null;
        }
        
        return new DexStagingCost
        {
            AccountId = accountId,
            TradeTypeId = tradeType?.TradeTypeId ?? 8,
            InputDate = DateTime.Today,
            TradeDate = transaction.TradeDate,
            ValueDate = transaction.ValueDate,
            Currency = transaction.Currency,
            Amount = costAmount * (tradeType?.AmountFactor ?? 1),
            BankCostId = bank.GetBankCostId(costType),
            DexTableId = (int)bank.GetTransactionTableFromTradeType(transaction.TradeType),
            PpTransaction = 1,
            CashImpact = tradeType?.CashImpact ?? 1,
            StagingTableRef = tableRef
        };
    }
}