using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Infrastructure;
using DataAccess.DatabaseAccess.Models;
using DataAccess.FileAccess.BankFileTypes.Saxo;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Deleters;

public interface IDeleter
{
    public void DeleteClientInstrumentHoldingsForDate(DateTime holdingDate, List<int> excludedDepotIds);
    public void DeleteClientCashHoldingsForDate(DateTime holdingDate, List<int> excludedAccountIds);
    public void DeleteInstrumentComparisonsForDate(DateTime holdingDate);
    public void DeleteCashComparisonsForDate(DateTime holdingDate);
    public void DeleteInstrumentCountryAllocsFordDate(DateTime holdingDate);
    public void DeleteInstrumentSectorAllocsFordDate(DateTime holdingDate);
    public void DeletePpFundAssetAllocsFordDate(DateTime holdingDate);
}

public class Deleter(IDbContextFactory<PpcapitalContext> contextFactory) : IDeleter
{
    public void DeleteClientInstrumentHoldingsForDate(DateTime holdingDate, List<int> excludedDepotIds)
    {
        using var context = contextFactory.CreateDbContext();
        context.DexClientInstHoldings.RemoveRange(context.DexClientInstHoldings.Where(holding => holding.HoldingDate == holdingDate && !excludedDepotIds.Contains(holding.DepotId)));
        context.SaveChanges();
    }

    public void DeleteClientCashHoldingsForDate(DateTime holdingDate, List<int> excludedAccountIds)
    {
        using var context = contextFactory.CreateDbContext();
        context.DexClientCashHoldings.RemoveRange(context.DexClientCashHoldings.Where(holding => holding.HoldingDate == holdingDate && !excludedAccountIds.Contains(holding.AccountId)));
        context.SaveChanges();
    }

    public void DeleteInstrumentComparisonsForDate(DateTime holdingDate)
    {
        using var context = contextFactory.CreateDbContext();
        context.DexComparisonsInstruments.RemoveRange(context.DexComparisonsInstruments.Where(holding => holding.HoldingDate == holdingDate));
        context.SaveChanges();
    }

    public void DeleteCashComparisonsForDate(DateTime holdingDate)
    {
        using var context = contextFactory.CreateDbContext();
        context.DexComparisonsCashes.RemoveRange(context.DexComparisonsCashes.Where(holding => holding.HoldingDate == holdingDate));
        context.SaveChanges();
    }

    public void DeleteInstrumentCountryAllocsFordDate(DateTime holdingDate)
    {
        using var context = contextFactory.CreateDbContext();
        context.DexInstrumentCntryAllocs.RemoveRange(context.DexInstrumentCntryAllocs.Where(holding => holding.AllocDate == holdingDate));
        context.SaveChanges();
    }

    public void DeleteInstrumentSectorAllocsFordDate(DateTime holdingDate)
    {
        using var context = contextFactory.CreateDbContext();
        context.DexInstrumentSectorAllocs.RemoveRange(context.DexInstrumentSectorAllocs.Where(holding => holding.AllocDate == holdingDate));
        context.SaveChanges();
    }

    public void DeletePpFundAssetAllocsFordDate(DateTime holdingDate)
    {
        using var context = contextFactory.CreateDbContext();
        context.DexPpFundAssetClassAllocs.RemoveRange(context.DexPpFundAssetClassAllocs.Where(holding => holding.AllocDate == holdingDate));
        context.SaveChanges();
    }
}