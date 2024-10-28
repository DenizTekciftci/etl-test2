using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTradeTypeNew
{
    public int Id { get; set; }

    public DateTime InputDate { get; set; }

    public string RefTable { get; set; } = null!;

    public string? BankTypeName { get; set; }

    public int? TradeTypeId { get; set; }

    public sbyte? IsinExists { get; set; }

    public double? QuantityFactor { get; set; }

    public double? AmountFactor { get; set; }

    public double? GrossFactor { get; set; }

    public double? CostsFactor { get; set; }

    public sbyte? NominalImpact { get; set; }

    public sbyte? CashImpact { get; set; }

    public virtual DexTradeTypeId? TradeType { get; set; }
}
