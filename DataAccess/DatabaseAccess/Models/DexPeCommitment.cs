using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexPeCommitment
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int DepotId { get; set; }

    public int InstrumentId { get; set; }

    public double Commitment { get; set; }

    public string Currency { get; set; } = null!;

    public DateTime? ExpiryDate { get; set; }

    public virtual DexClientDepot Depot { get; set; } = null!;

    public virtual DexInstrument Instrument { get; set; } = null!;
}
