using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTradeTypeSaxo
{
    public int Id { get; set; }

    public string? BankTypeName { get; set; }

    public int TradeTypeId { get; set; }

    public int AmountFactor { get; set; }

    public int CostsFactor { get; set; }

    public sbyte NominalImpact { get; set; }

    public sbyte CashImpact { get; set; }

    public virtual DexTradeTypeId TradeType { get; set; } = null!;
}
