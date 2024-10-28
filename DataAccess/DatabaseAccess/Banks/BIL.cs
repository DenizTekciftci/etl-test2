using DataAccess.DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Banks;

public class BIL(IDbContextFactory<PpcapitalContext> contextFactory) : Bank<DexTradeTypeBil>(contextFactory)
{
    protected override string BankName => "BIL LUX";
    protected override string TradeTypesTableName => "dex_trade_type_bil";
}