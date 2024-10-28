using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class UnderlyingFundCashHoldingsWithPct
{
    public DateTime? HoldingDate { get; set; }

    public long? ClientPpId { get; set; }

    public string? BbTicker { get; set; }

    public string? SecurityName { get; set; }

    public double? ValueDkk { get; set; }

    public double? PctShare { get; set; }
}
