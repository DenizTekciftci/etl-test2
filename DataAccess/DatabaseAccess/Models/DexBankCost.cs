using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexBankCost
{
    public int BankCostId { get; set; }

    public int BankId { get; set; }

    public string? BankCostName { get; set; }

    public int CostTypeId { get; set; }

    public string? BankCostDescription { get; set; }

    public sbyte? AddToCostOverview { get; set; }

    public virtual DexBank Bank { get; set; } = null!;

    public virtual DexCostType CostType { get; set; } = null!;

    public virtual ICollection<DexCost> DexCosts { get; set; } = new List<DexCost>();

    public virtual ICollection<DexStagingCost> DexStagingCosts { get; set; } = new List<DexStagingCost>();
}
