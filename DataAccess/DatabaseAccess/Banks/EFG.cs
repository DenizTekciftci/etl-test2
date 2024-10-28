using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Banks;

public class EFG(IDbContextFactory<PpcapitalContext> contextFactory) : Bank<DexTradeTypeEfg>(contextFactory)
{
    protected override string BankName { get; } = "EFG Bank Luxembourg";
    protected override string TradeTypesTableName { get; } = "dex_trade_type_efg";
}