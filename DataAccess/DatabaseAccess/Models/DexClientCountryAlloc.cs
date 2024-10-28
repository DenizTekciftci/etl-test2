using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientCountryAlloc
{
    public int Id { get; set; }

    public DateTime AllocDate { get; set; }

    public int ClientPpId { get; set; }

    public string GeographicalRegion { get; set; } = null!;

    public double CountryWeightAlloc { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
