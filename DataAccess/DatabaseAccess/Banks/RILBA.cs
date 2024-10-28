using DataAccess.DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Banks;

public class RILBA(IDbContextFactory<PpcapitalContext> contextFactory) : Bank<DexTradeTypeRilba>(contextFactory)
{
    protected override string BankName => "Ringkjøbing Landbobank";
    protected override string TradeTypesTableName => "dex_trade_type_rilba";
}