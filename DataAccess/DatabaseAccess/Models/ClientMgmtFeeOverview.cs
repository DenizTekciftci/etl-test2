using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientMgmtFeeOverview
{
    public int? ClientPpId { get; set; }

    public int DepotId { get; set; }

    public string? DepotTypeDa { get; set; }

    public string FeeType { get; set; } = null!;

    public double FeeAmount { get; set; }
}
