using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexInstrumentSectorAlloc
{
    public int Id { get; set; }

    public DateTime AllocDate { get; set; }

    public int InstrumentId { get; set; }

    public string BbTicker { get; set; } = null!;

    public string IndustrySectorName { get; set; } = null!;

    public double IndustrySectorAllocationPercentage { get; set; }

    public virtual DexInstrument Instrument { get; set; } = null!;
}
