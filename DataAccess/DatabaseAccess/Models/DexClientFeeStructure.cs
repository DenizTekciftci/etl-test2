using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientFeeStructure
{
    public int Id { get; set; }

    public int DepotId { get; set; }

    public string FeeType { get; set; } = null!;

    public double FeeAmount { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public virtual DexClientDepot Depot { get; set; } = null!;
}
