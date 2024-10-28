using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class LatestInstrumentHolding
{
    public DateTime HoldingDate { get; set; }

    public int DepotId { get; set; }

    public int InstrumentId { get; set; }

    public double Quantity { get; set; }

    public double? Price { get; set; }

    public double? IntAcc { get; set; }

    public double? PriceFactor { get; set; }

    public double? PrincipalFactor { get; set; }

    public double? ValueDkk { get; set; }

    public double? ValueRepCur { get; set; }
}
