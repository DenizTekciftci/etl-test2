using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class VallerodBenchmarkReturn
{
    public int Id { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime PriceDate { get; set; }

    public int InstrumentId { get; set; }

    public double Price { get; set; }

    public double IntAcc { get; set; }

    public double ModDur { get; set; }

    public double PriceFactor { get; set; }

    public double PrincipalFactor { get; set; }
}
