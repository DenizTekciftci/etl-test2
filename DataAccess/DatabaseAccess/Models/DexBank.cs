using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexBank
{
    public int BankId { get; set; }

    public string? Bank { get; set; }

    public string? JbCode { get; set; }

    public string? Ec { get; set; }

    public string CountryName { get; set; } = null!;

    public virtual ICollection<DexBankCost> DexBankCosts { get; set; } = new List<DexBankCost>();

    public virtual ICollection<DexClientDepot> DexClientDepots { get; set; } = new List<DexClientDepot>();

    public virtual ICollection<DexClientDepotsNew> DexClientDepotsNews { get; set; } = new List<DexClientDepotsNew>();

    public virtual ICollection<DexMgmtPerfFee> DexMgmtPerfFees { get; set; } = new List<DexMgmtPerfFee>();
}
