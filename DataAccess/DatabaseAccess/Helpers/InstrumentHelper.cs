using DataAccess.DatabaseAccess.Models;
using DataAccess.DatabaseAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Helpers;

public interface IInstrumentHelper
{
    public int GetInstrumentIdByIsin(string isin);
    public DexInstrument GetInstrumentByIsin(string isin);
    public string GetISINByFundCode(int fundCode);
}    


public class InstrumentHelper(IDbContextFactory<PpcapitalContext> contextFactory) : IInstrumentHelper
{
    public int GetInstrumentIdByIsin(string isin)
    {
        return GetInstrumentByIsin(isin).InstrumentId;
    }
    
    public DexInstrument GetInstrumentByIsin(string isin)
    {
        using var context = contextFactory.CreateDbContext();
        var instruments = InstrumentRepository.GetInstrumentsByIsin(context, isin);
        if (instruments.Count == 1) return instruments.First();
        
        // If there are 0 or more than 1 returned instrument, manual input is needed
        MissingDataHelper.InsertNewInstrument(context, isin);
        throw new Exception(Consts.InstrumentNotFoundError(isin));
    }

    public string GetISINByFundCode(int fundCode)
    {
        using var context = contextFactory.CreateDbContext();
        var fundCodes = InstrumentRepository.GetFundCodeByFundCode(context, fundCode);
        if (fundCodes.Count == 1) return fundCodes.First().Isin ?? "";
        throw new Exception(Consts.FundCodeNotFound(fundCode));
    }
}