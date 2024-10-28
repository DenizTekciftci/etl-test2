using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientFeeCap
{
    public int Id { get; set; }

    public int ClientPpId { get; set; }

    public string FeeType { get; set; } = null!;

    public string CapType { get; set; } = null!;

    public double Amount { get; set; }

    public string Horizon { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
