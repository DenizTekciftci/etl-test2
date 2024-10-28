using DataAccess.DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Banks;

public class JyskeBank(IDbContextFactory<PpcapitalContext> contextFactory) : Bank<DexTradeTypeJyske>(contextFactory)
{
    protected override string BankName => "Jyske Bank";
    protected override string TradeTypesTableName => "dex_trade_type_jyske";
}