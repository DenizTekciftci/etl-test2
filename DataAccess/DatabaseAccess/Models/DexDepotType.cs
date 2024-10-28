using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexDepotType
{
    public int DepotTypeId { get; set; }

    public string DepotType { get; set; } = null!;

    public string DepotTypeDa { get; set; } = null!;

    public virtual ICollection<DexClientDepot> DexClientDepots { get; set; } = new List<DexClientDepot>();

    public virtual ICollection<DexClientDepotsNew> DexClientDepotsNews { get; set; } = new List<DexClientDepotsNew>();
}
