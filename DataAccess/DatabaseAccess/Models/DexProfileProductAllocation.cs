using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexProfileProductAllocation
{
    public int Id { get; set; }

    public string ClientProfile { get; set; } = null!;

    public string Product { get; set; } = null!;

    public double Target { get; set; }
}
