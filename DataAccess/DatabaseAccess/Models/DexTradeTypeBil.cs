using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTradeTypeBil
{
    public int Id { get; set; }

    public string? BankTypeName { get; set; }

    public int TradeTypeId { get; set; }

    public double? QuantityFactor { get; set; }

    public double? AmountFactor { get; set; }

    public double? GrossFactor { get; set; }

    public double? CostsFactor { get; set; }

    public sbyte NominalImpact { get; set; }

    public sbyte CashImpact { get; set; }

    public virtual DexTradeTypeId TradeType { get; set; } = null!;
}
