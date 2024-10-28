using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexProfileAllocationSe
{
    public int Id { get; set; }

    public int InstrumentId { get; set; }

    public string Ticker { get; set; } = null!;

    public string Isin { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Fx { get; set; } = null!;

    public double? Offensiv { get; set; }

    public double? Balanceret { get; set; }

    public double? Moderat { get; set; }

    public double? Konservativ { get; set; }

    public string AssetClass { get; set; } = null!;

    public string Component { get; set; } = null!;

    public string SupplementalTickers { get; set; } = null!;

    public string SupplementalCurrency { get; set; } = null!;
}
