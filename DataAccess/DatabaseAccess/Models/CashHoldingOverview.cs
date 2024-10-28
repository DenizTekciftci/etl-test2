using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class CashHoldingOverview
{
    public DateTime HoldingDate { get; set; }

    public int? ClientPpId { get; set; }

    public int? DepotId { get; set; }

    public string? Depot { get; set; }

    public int AccountId { get; set; }

    public string? Account { get; set; }

    public double AmountAccCur { get; set; }

    public string? Currency { get; set; }
}
