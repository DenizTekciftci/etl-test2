using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexBmWeight
{
    public int Id { get; set; }

    public int BmId { get; set; }

    public int InstrumentId { get; set; }

    public string BbTicker { get; set; } = null!;

    public string? Isin { get; set; }

    public double WeightPct { get; set; }

    public virtual DexBm Bm { get; set; } = null!;

    public virtual DexInstrument Instrument { get; set; } = null!;
}
