using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexInstrumentsSfdr
{
    public int InstrumentId { get; set; }

    public int? Sfdr { get; set; }
}
