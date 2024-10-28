using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class TradingBookActiveInstrumentsWithLatestPrice
{
    public int InstrumentId { get; set; }

    public string BbTicker { get; set; } = null!;

    public string? SecurityName { get; set; }

    public string? Isin { get; set; }

    public string? Issuer { get; set; }

    public string AssetClass { get; set; } = null!;

    public DateTime? PriceDate { get; set; }

    public double? Price { get; set; }

    public double? ExRate { get; set; }

    public double? IntAcc { get; set; }

    public double? ModDur { get; set; }

    public double? PriceFactor { get; set; }

    public double? PrincipalFactor { get; set; }

    public double? Deduction { get; set; }

    public string? Currency { get; set; }
}
