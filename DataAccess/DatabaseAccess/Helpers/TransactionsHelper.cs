using DataAccess.DatabaseAccess.Infrastructure;
using DataAccess.DatabaseAccess.Models;

namespace DataAccess.DatabaseAccess.Helpers;

public class TransactionsHelper(PpcapitalContext context)
{
    public List<ITransactionType> GetTransactionsWithLaterValueDate(DateTime date)
    {
        var valueTransactions = new List<ITransactionType>();
        
        // Get all transactions
        var valueSecurityTransactions = context.DexSecurityTransactions.Where(x => x.ValueDate > date && x.TradeDate <= date);  
        var valueDividendTransactions = context.DexDividendTransactions.Where(x => x.ValueDate > date && x.TradeDate <= date);
        var valueCashTransactions = context.DexCashTransactions.Where(x => x.ValueDate > date && x.TradeDate <= date);
        var valueBondCouponTransactions = context.DexBondCoupons.Where(x => x.ValueDate > date && x.TradeDate <= date);
        var valueCosts = context.DexCosts.Where(x => x.ValueDate > date && x.TradeDate <= date);
        var invertedCosts = valueCosts.ToList().Select(x =>
        {
            x.Amount *= -1;
            return x;
        });
        var valuePerformanceFee = context.DexMgmtPerfFees
            .Where(x => x.ValueDate > date && x.FeeDate <= date)
            .Select(x => new DexCost
            {
                ValueDate = x.ValueDate,
                TradeDate = x.FeeDate,
                Amount = x.FeeGrossVat,
                Currency = x.Currency,
                PpTransaction = x.PpTransaction,
                CashImpact = x.CashImpact,
                AccountId = x.AccountId,
            });
        
        // Add them to the list
        valueTransactions.AddRange(valueSecurityTransactions);
        valueTransactions.AddRange(valueDividendTransactions);
        valueTransactions.AddRange(valueCashTransactions);
        valueTransactions.AddRange(valueBondCouponTransactions);
        valueTransactions.AddRange(valueBondCouponTransactions);
        valueTransactions.AddRange(invertedCosts);
        valueTransactions.AddRange(valuePerformanceFee);
        
        // Filter out inactive accounts/depots
        var activeAccounts = 
            from returnGroup in context.DexClientReturnGroups
            join accounts in context.DexClientAccounts on returnGroup.DepotId equals accounts.DepotId
            where returnGroup.StartDate <= date && date <= returnGroup.EndDate
            select accounts.AccountId;
        
        return valueTransactions.Where(x => activeAccounts.Contains(x.AccountId)).ToList();
    }

    public List<ITransactionType> GetTransactionsOnDate(DateTime date)
    {
        var valueTransactions = new List<ITransactionType>();

        // Get all transactions
        var valueSecurityTransactions = context.DexSecurityTransactions.Where(x => x.TradeDate == date);
        var valueDividendTransactions = context.DexDividendTransactions.Where(x => x.TradeDate == date);
        var valueCashTransactions = context.DexCashTransactions.Where(x => x.TradeDate == date);
        var valueBondCouponTransactions = context.DexBondCoupons.Where(x => x.TradeDate == date);
        // Cost impacts are inverse
        var valueCosts = context.DexCosts.Where(x => x.TradeDate == date).ToList();
        var invertedCosts = valueCosts.Select(x =>
        {
            x.Amount *= -1;
            return x;
        });
        var valuePerformanceFee = context.DexMgmtPerfFees
            .Where(x => x.FeeDate == date)
            .Select(x => new DexCost
            {
                ValueDate = x.ValueDate,
                TradeDate = x.FeeDate,
                Amount = x.FeeGrossVat,
                Currency = x.Currency,
                PpTransaction = x.PpTransaction,
                CashImpact = x.CashImpact,
                AccountId = x.AccountId,
            });

        // Add them to the list
        valueTransactions.AddRange(valueSecurityTransactions);
        valueTransactions.AddRange(valueDividendTransactions);
        valueTransactions.AddRange(valueCashTransactions);
        valueTransactions.AddRange(valueBondCouponTransactions);
        valueTransactions.AddRange(valueBondCouponTransactions);
        valueTransactions.AddRange(invertedCosts);
        valueTransactions.AddRange(valuePerformanceFee);

        // Filter out inactive accounts/depots
        var activeAccounts =
            from returnGroup in context.DexClientReturnGroups
            join accounts in context.DexClientAccounts on returnGroup.DepotId equals accounts.DepotId
            where returnGroup.StartDate <= date && date <= returnGroup.EndDate
            select accounts.AccountId;

        return valueTransactions.Where(x => activeAccounts.Contains(x.AccountId)).ToList();
    }

    public List<DexSecurityTransaction> GetSecurityTransactionsTradedOnDate(DateTime date)
    {
        // Get all security transactions
        var valueSecurityTransactions = context.DexSecurityTransactions.Where(x => x.TradeDate == date);  
        
        // Filter out inactive accounts/depots
        var activeAccounts = (
            from returnGroup in context.DexClientReturnGroups
            join accounts in context.DexClientAccounts on returnGroup.DepotId equals accounts.DepotId
            where returnGroup.StartDate <= date && date <= returnGroup.EndDate
            select accounts.AccountId);
        
        return valueSecurityTransactions.Where(x => activeAccounts.Contains(x.AccountId)).ToList();
    }

    public List<DexSecurityTransaction> GetSecurityTransactionsWithLaterValueDate(DateTime date)
    {
        // Get all security transactions
        var valueSecurityTransactions = context.DexSecurityTransactions.Where(x => x.ValueDate > date && x.TradeDate <= date);

        // Filter out inactive accounts/depots
        var activeAccounts = (
            from returnGroup in context.DexClientReturnGroups
            join accounts in context.DexClientAccounts on returnGroup.DepotId equals accounts.DepotId
            where returnGroup.StartDate <= date && date <= returnGroup.EndDate
            select accounts.AccountId);

        return valueSecurityTransactions.Where(x => activeAccounts.Contains(x.AccountId)).ToList();
    }
}