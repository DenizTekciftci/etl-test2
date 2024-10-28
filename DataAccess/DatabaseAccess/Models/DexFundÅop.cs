using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexFundÅop
{
    public int Id { get; set; }

    public int InstrumentId { get; set; }

    public int Year { get; set; }

    public double LøbendeFeeTotal { get; set; }

    public double LøbendeFeePp { get; set; }

    public double LøbendeFee3rd { get; set; }

    public double PerformanceFee { get; set; }

    public virtual DexInstrument Instrument { get; set; } = null!;
}
