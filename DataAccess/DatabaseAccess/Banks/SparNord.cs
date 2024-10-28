using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Banks;

public class SparNord(IDbContextFactory<PpcapitalContext> contextFactory) : Bank<DexTradeTypeSparnord>(contextFactory)
{
    protected override string BankName { get; } = "Spar Nord Bank";
    protected override string TradeTypesTableName { get; } = "dex_trade_type_sparnord";
}