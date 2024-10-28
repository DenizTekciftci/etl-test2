using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IndtjeningPerCappedKunde
{
    public int? ClientPpId { get; set; }

    public int? Year { get; set; }

    public double? AftaltFeeCapPct { get; set; }

    public double? IndtjeningSoFar { get; set; }

    public double? FeePctAum { get; set; }

    public double? LatestAum { get; set; }
}
