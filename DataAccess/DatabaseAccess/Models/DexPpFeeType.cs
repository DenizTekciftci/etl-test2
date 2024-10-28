using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexPpFeeType
{
    public int FeeTypeId { get; set; }

    public string? FeeDescription { get; set; }

    public string FeeType { get; set; } = null!;

    public virtual ICollection<DexMgmtPerfFee> DexMgmtPerfFees { get; set; } = new List<DexMgmtPerfFee>();
}
