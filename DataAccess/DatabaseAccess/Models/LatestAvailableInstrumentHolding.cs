using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class LatestAvailableInstrumentHolding
{
    public DateTime HoldingDate { get; set; }

    public int? ClientPpId { get; set; }

    public int DepotId { get; set; }

    public int InstrumentId { get; set; }

    public string? BbTicker { get; set; }

    public string? Isin { get; set; }

    public double Quantity { get; set; }
}
