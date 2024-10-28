using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientFeeFilter
{
    public int Id { get; set; }

    public int DepotId { get; set; }

    public string FeeType { get; set; } = null!;

    public int? InstrumentId { get; set; }

    public string? AssetClass { get; set; }

    public string? CountryIso { get; set; }

    public string? SpecialCase { get; set; }

    public double FeeAmount { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public virtual DexClientDepot Depot { get; set; } = null!;
}
