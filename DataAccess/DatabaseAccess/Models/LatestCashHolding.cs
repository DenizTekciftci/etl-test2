using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class LatestCashHolding
{
    public DateTime HoldingDate { get; set; }

    public int AccountId { get; set; }

    public double AmountAccCur { get; set; }

    public double? AmountDkk { get; set; }

    public double? AmountRepCur { get; set; }
}
