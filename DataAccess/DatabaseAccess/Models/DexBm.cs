using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexBm
{
    public int BmId { get; set; }

    public string? BmName { get; set; }

    public string? BmLongName { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<DexBmReturn> DexBmReturns { get; set; } = new List<DexBmReturn>();

    public virtual ICollection<DexBmWeight> DexBmWeights { get; set; } = new List<DexBmWeight>();

    public virtual ICollection<DexClientBenchmark> DexClientBenchmarks { get; set; } = new List<DexClientBenchmark>();
}
