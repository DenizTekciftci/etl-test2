using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTradeTypeRilba
{
    public int Id { get; set; }

    public string BankTypeName { get; set; } = null!;

    public int TradeTypeId { get; set; }

    public sbyte QuantityFactor { get; set; }

    public sbyte AmountFactor { get; set; }

    public sbyte NominalImpact { get; set; }

    public sbyte CashImpact { get; set; }

    public virtual DexTradeTypeId TradeType { get; set; } = null!;
}
