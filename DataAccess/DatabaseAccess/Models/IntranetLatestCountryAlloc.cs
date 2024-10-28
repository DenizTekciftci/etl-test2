using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetLatestCountryAlloc
{
    public DateTime AllocDate { get; set; }

    public int ClientPpId { get; set; }

    public string Country { get; set; } = null!;

    public double Weight { get; set; }
}
