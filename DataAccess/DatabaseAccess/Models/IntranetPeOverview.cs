using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetPeOverview
{
    public int? ClientPpId { get; set; }

    public string? ClientName { get; set; }

    public string? SecurityName { get; set; }

    public double? Commitment { get; set; }

    public string Currency { get; set; } = null!;

    public double? Remaining { get; set; }

    public double? ValueCommitmentCur { get; set; }

    public double? TrukketCommitmentCur { get; set; }
}
