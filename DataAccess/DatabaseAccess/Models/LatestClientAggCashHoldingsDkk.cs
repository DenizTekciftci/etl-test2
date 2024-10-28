using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class LatestClientAggCashHoldingsDkk
{
    public DateTime HoldingDate { get; set; }

    public int? ClientPpId { get; set; }

    public double? CashDkk { get; set; }
}
