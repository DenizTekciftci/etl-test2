using DataAccess.DatabaseAccess.Models;
using DataAccess.DatabaseAccess.Repositories;

namespace DataAccess.DatabaseAccess.Helpers;

public class TradeTypeHelper
{
    public static DexTradeTypeId GetTradeType(PpcapitalContext context, int tradeTypeId)
    {
        var tradeType = TradeTypeRepository.GetTradeTypeById(context, tradeTypeId);
        if (tradeType != null) return tradeType;
        
        throw new Exception($"No tradetype with id: {tradeTypeId}");
    }
}