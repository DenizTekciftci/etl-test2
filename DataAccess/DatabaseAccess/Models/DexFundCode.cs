using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexFundCode
{
    public int FundCode { get; set; }

    public int InstrumentId { get; set; }

    public string? Isin { get; set; }

    public virtual DexInstrument Instrument { get; set; } = null!;
}
