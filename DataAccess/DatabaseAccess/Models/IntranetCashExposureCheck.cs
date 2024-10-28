using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetCashExposureCheck
{
    public DateTime HoldingDate { get; set; }

    public int? ClientPpId { get; set; }

    public string? ClientName { get; set; }

    public double? CashAgg { get; set; }

    public string? Currency { get; set; }

    public double? CashAmountDkk { get; set; }

    public double? TotalAumDkk { get; set; }

    public double? CashPct { get; set; }
}
