using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class LatestCashHoldingsDkk
{
    public DateTime HoldingDate { get; set; }

    public int AccountId { get; set; }

    public int? ClientPpId { get; set; }

    public double AmountAccCur { get; set; }

    public int? DepotId { get; set; }

    public double? AmountDkk { get; set; }
}
