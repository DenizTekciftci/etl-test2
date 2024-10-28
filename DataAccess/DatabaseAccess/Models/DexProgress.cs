using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexProgress
{
    public string Process { get; set; } = null!;

    public sbyte Step { get; set; }

    public sbyte Status { get; set; }

    public DateTime LastRunDate { get; set; }

    public sbyte Success { get; set; }

    public string? ErrorMsg { get; set; }
}
