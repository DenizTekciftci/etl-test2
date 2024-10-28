using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class InstrumentsSfdr
{
    public int InstrumentId { get; set; }

    public string BbTicker { get; set; } = null!;

    public string? Isin { get; set; }

    public string? SecurityName { get; set; }

    public int? Sfdr { get; set; }
}
