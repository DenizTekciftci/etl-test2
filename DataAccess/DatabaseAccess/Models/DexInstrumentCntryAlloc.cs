using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexInstrumentCntryAlloc
{
    public int Id { get; set; }

    public DateTime AllocDate { get; set; }

    public int InstrumentId { get; set; }

    public string BbTicker { get; set; } = null!;

    public string GeographicalRegion { get; set; } = null!;

    public double PercentOfFund { get; set; }

    public virtual DexInstrument Instrument { get; set; } = null!;
}
