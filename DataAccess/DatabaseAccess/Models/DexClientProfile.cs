using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientProfile
{
    public int Id { get; set; }

    public int ClientPpId { get; set; }

    public string RiskProfile { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
