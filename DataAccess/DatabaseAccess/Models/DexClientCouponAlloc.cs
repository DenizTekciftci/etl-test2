using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientCouponAlloc
{
    public int Id { get; set; }

    public DateTime AllocDate { get; set; }

    public int ClientPpId { get; set; }

    public string CouponType { get; set; } = null!;

    public double AllocPct { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
