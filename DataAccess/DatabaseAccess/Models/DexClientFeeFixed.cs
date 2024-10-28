using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientFeeFixed
{
    public int Id { get; set; }

    public int DepotId { get; set; }

    public string FeeType { get; set; } = null!;

    public double Amount { get; set; }

    public string Currency { get; set; } = null!;

    public int Frequency { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}
