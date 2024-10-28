using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientBenchmark
{
    public int Id { get; set; }

    public int ClientPpId { get; set; }

    public int BmId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public virtual DexBm Bm { get; set; } = null!;

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
