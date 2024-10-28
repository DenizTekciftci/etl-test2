using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class VallerodAssetClassesAlloc
{
    public DateTime AllocDate { get; set; }

    public double? EquityPct { get; set; }

    public double? KontantPct { get; set; }

    public double? AlternativerPct { get; set; }

    public double? RealkreditobligationerPct { get; set; }

    public double? StatsobligationerPct { get; set; }

    public double? KreditobligationerPct { get; set; }
}
