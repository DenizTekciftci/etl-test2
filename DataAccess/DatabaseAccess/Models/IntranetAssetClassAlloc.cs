using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetAssetClassAlloc
{
    public DateTime AllocDate { get; set; }

    public long ClientPpId { get; set; }

    public string? AssetClass { get; set; }

    public double AssetClassPct { get; set; }
}
