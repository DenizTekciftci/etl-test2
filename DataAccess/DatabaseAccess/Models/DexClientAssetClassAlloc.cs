using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientAssetClassAlloc
{
    public int Id { get; set; }

    public DateTime AllocDate { get; set; }

    public int ClientPpId { get; set; }

    public string AssetClass { get; set; } = null!;

    public double AssetClassPct { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
