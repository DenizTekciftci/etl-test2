using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexFtDeductionCap
{
    public int Id { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public float Cap { get; set; }

    public float Deduction { get; set; }
}
