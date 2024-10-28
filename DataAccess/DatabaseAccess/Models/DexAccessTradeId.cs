using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexAccessTradeId
{
    public int HandelsIk { get; set; }

    public int TradeTypeId { get; set; }

    public int CashImpact { get; set; }

    public virtual DexTradeTypeId TradeType { get; set; } = null!;
}
