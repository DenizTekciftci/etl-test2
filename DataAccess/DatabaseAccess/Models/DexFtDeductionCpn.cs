using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexFtDeductionCpn
{
    public int Id { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public float Coupon { get; set; }

    public float Maturity10 { get; set; }

    public float Maturity1020 { get; set; }

    public float Maturity20 { get; set; }
}
