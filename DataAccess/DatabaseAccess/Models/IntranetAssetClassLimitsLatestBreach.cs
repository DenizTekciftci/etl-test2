using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetAssetClassLimitsLatestBreach
{
    public DateTime AllocDate { get; set; }

    public int ClientPpId { get; set; }

    public string? ClientName { get; set; }

    public string AssetClass { get; set; } = null!;

    public int? MinLimit { get; set; }

    public double? AssetClassPct { get; set; }

    public int? MaxLimit { get; set; }
}
