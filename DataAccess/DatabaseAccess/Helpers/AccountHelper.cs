using DataAccess.DatabaseAccess.Models;
using DataAccess.DatabaseAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Helpers;

public interface IAccountHelper
{
    public int GetAccountId(string account, string currency, int bankId);
    public string GetAccountNameFromDepotNameAndCurrency(string depot, string currency);
}

public class AccountHelper(IDbContextFactory<PpcapitalContext> contextFactory) : IAccountHelper
{
    public int GetAccountId(string account, string currency, int bankId)
    {
        var context = contextFactory.CreateDbContext();
        var accountIds = AccountsRepository.GetAccountIdsByAccount(context, account);
        if (accountIds.Count == 1) return accountIds.First();
      
        // Assuming we don't have accountNumber collisions internally in a bank
        MissingDataHelper.InsertNewAccount(context, account, currency, bankId);
        throw new Exception(Consts.AccountNotFoundError(account));
    }
    
    public string GetAccountNameFromDepotNameAndCurrency(string depot, string currency)
    {
        // Get accounts by depot
        // If accounts.Count == 1, return this
        // Else, if account.Count > 1, return the account that matches the currency
        // Fallback, choose the first account
        var context = contextFactory.CreateDbContext();
        var accounts = AccountsRepository.GetAccountsByDepot(context, depot);
        if (accounts.Count == 1) return accounts.First().Account!;
        if (accounts.Count == 0) throw new Exception(Consts.AccountNotFoundForDepotAndCurrencyError(depot, currency));
        
        // TODO Fix this
        // This should create some sort of manual job labelling where the instrument goes
        // Idea, this should only be done the first time for each instrument, if we find what account was used last time
        // for the current instrument, use it again.
        // Could cause wrong classification if multiple accounts have the same instruments 
        return accounts.FirstOrDefault(a => a.Currency == currency)?.Account ?? throw new Exception("Missing account name");
    }
}