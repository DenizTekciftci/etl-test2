using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class LatestFundInstHolding
{
    public DateTime HoldingDate { get; set; }

    public int? ClientPpId { get; set; }

    public string? BbTicker { get; set; }

    public string? Isin { get; set; }

    public string? SecurityName { get; set; }

    public string? Currency { get; set; }

    public double Quantity { get; set; }

    public double? Price { get; set; }

    public double? ValueDkk { get; set; }

    public double? Weight { get; set; }

    public string? AssetClass { get; set; }
}
