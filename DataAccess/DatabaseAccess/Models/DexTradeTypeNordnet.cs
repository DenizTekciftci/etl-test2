using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTradeTypeNordnet
{
    public int Id { get; set; }

    public string? BankTypeName { get; set; }

    public int TradeTypeId { get; set; }

    public bool IsinExists { get; set; }

    public double QuantityFactor { get; set; }

    public double AmountFactor { get; set; }

    public bool NominalImpact { get; set; }

    public bool CashImpact { get; set; }

    public virtual DexTradeTypeId TradeType { get; set; } = null!;
}
