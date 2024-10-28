using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Models;

namespace Tests.Mock;

public class MockInstrumentHelper : IInstrumentHelper
{
    public int GetInstrumentIdByIsin(string isin)
    {
        return 0;
    }

    public DexInstrument GetInstrumentByIsin(string isin)
    {
        throw new NotImplementedException();
    }

    public string GetISINByFundCode(int fundCode)
    {
        return "TESTISIN12345";
    }

    public int GetInstrumentIdByFundCode(int fundCode)
    {
        return 0;
    }
}