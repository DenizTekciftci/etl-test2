using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientAllocLimit
{
    public int Id { get; set; }

    public int ClientPpId { get; set; }

    public string AssetClass { get; set; } = null!;

    public int MinLimit { get; set; }

    public int MaxLimit { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
