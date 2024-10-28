using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexCostType
{
    public int CostTypeId { get; set; }

    public string CostTypeName { get; set; } = null!;

    public string CostTypeNameDa { get; set; } = null!;

    public virtual ICollection<DexBankCost> DexBankCosts { get; set; } = new List<DexBankCost>();
}
