using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientVat
{
    public int Id { get; set; }

    public int DepotId { get; set; }

    public sbyte Vat { get; set; }

    public virtual DexClientDepot Depot { get; set; } = null!;
}
