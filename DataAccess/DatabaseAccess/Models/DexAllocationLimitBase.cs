using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexAllocationLimitBase
{
    public int Id { get; set; }

    public string ClientProfile { get; set; } = null!;

    public string AssetClass { get; set; } = null!;

    public double MinLimit { get; set; }

    public double MaxLimit { get; set; }
}
