using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexInstrumentsUnlisted
{
    public int InstrumentUnlistedId { get; set; }

    public string? Isin { get; set; }

    public string? Currency { get; set; }
}
