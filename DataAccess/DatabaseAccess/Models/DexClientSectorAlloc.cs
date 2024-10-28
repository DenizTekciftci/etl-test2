using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

/// <summary>
/// Table contains information about underlying fund exposure. 
/// </summary>
public partial class DexClientSectorAlloc
{
    public int Id { get; set; }

    public DateTime AllocDate { get; set; }

    public int ClientPpId { get; set; }

    public string IndustrySectorName { get; set; } = null!;

    public double InstSectorWeightAlloc { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
