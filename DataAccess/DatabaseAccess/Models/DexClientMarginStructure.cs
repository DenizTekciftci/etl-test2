using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientMarginStructure
{
    public int Id { get; set; }

    public int ClientPpId { get; set; }

    public string AssetClass { get; set; } = null!;

    public string FeeType { get; set; } = null!;

    public double FeeAmount { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
