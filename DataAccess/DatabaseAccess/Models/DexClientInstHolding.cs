using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientInstHolding
{
    public int Id { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime HoldingDate { get; set; }

    public int DepotId { get; set; }

    public int InstrumentId { get; set; }

    public double Quantity { get; set; }

    public virtual DexClientDepot Depot { get; set; } = null!;

    public virtual DexInstrument Instrument { get; set; } = null!;
}
