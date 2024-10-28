using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Banks;

public class SaxoBank(IDbContextFactory<PpcapitalContext> contextFactory) : Bank<DexTradeTypeSaxo>(contextFactory)
{
    protected override string BankName { get; } = "Saxo Bank";
    protected override string TradeTypesTableName { get; } = "dex_trade_type_saxo";
}