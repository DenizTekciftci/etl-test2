using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetLatestSectorAlloc
{
    public DateTime AllocDate { get; set; }

    public long ClientPpId { get; set; }

    public string Sector { get; set; } = null!;

    public double Weight { get; set; }
}
