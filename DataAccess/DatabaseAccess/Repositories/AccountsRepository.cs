using DataAccess.DatabaseAccess.Models;

namespace DataAccess.DatabaseAccess.Repositories;

public static class AccountsRepository
{
    public static List<int> GetAccountIdsByAccount(PpcapitalContext context, string account)
    {
        return context.DexClientAccounts
            .Where(a => a.Account == account)
            .Select(a => a.AccountId)
            .ToList();
    }

    public static List<DexClientAccount> GetAccountsByDepot(PpcapitalContext context, string depot)
    {
        var accountNames = (
            from dca in context.DexClientAccounts
            join dcd in context.DexClientDepots.Where(d => d.Depot == depot) on dca.DepotId equals dcd.DepotId
            select dca
        ).ToList();

        return accountNames;
    }
}