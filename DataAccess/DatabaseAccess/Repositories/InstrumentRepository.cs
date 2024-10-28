using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Models;

namespace DataAccess.DatabaseAccess.Repositories;

public static class InstrumentRepository
{
    public static List<DexInstrument> GetInstrumentsByIsin(PpcapitalContext context, string isin)
    {
        return context.DexInstruments.Where(i => i.Isin == isin).ToList();
    }
    
    public static List<DexFundCode> GetFundCodeByFundCode(PpcapitalContext context, int fundCode)
    {
        return context.DexFundCodes.Where(i => i.FundCode == fundCode).ToList();
    }
}