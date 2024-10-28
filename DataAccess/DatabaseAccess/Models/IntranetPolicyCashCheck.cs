using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetPolicyCashCheck
{
    public DateTime? HoldingDate { get; set; }

    public string Location { get; set; } = null!;

    public int? ClientPpId { get; set; }

    public string? ClientName { get; set; }

    public string? Depot { get; set; }

    public string? Account { get; set; }

    public string? Iban { get; set; }

    public double? CashAccCur { get; set; }

    public string? Currency { get; set; }

    public double? AumAccCur { get; set; }

    public double? CashPct { get; set; }
}
