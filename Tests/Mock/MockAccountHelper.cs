using DataAccess.DatabaseAccess.Helpers;

namespace Tests.Mock;

public class MockAccountHelper : IAccountHelper
{
    public int GetAccountId(string account, string currency, int bankId)
    {
        return 1;
    }

    public string GetAccountNameFromDepotNameAndCurrency(string depot, string currency)
    {
        return "testDepot";
    }
}