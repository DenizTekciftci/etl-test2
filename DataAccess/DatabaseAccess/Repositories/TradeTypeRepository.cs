using DataAccess.DatabaseAccess.Models;

namespace DataAccess.DatabaseAccess.Repositories;

public static class TradeTypeRepository
{
    public static DexTradeTypeId? GetTradeTypeById(PpcapitalContext context, int? id)
    {
        return id == null ? null : context.DexTradeTypeIds.FirstOrDefault(tt => tt.TradeTypeId == id);
    }
}