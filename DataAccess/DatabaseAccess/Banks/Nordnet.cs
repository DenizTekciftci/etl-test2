using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Banks;

public class Nordnet(IDbContextFactory<PpcapitalContext> contextFactory) : Bank<DexTradeTypeNordnetSe>(contextFactory)
{
    protected override string BankName { get; } = "Nordnet";
    protected override string TradeTypesTableName { get; } = "dex_trade_type_nordnet_se";
}