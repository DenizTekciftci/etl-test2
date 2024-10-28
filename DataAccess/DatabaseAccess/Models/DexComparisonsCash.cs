using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexComparisonsCash
{
    public int Id { get; set; }

    public DateTime? InputDate { get; set; }

    public DateTime? HoldingDate { get; set; }

    public decimal? PpAmount { get; set; }

    public decimal? BankAmount { get; set; }

    public int? AccountId { get; set; }

    public decimal? Value { get; set; }

    public string? Currency { get; set; }

    public decimal? Diff { get; set; }

    public sbyte Resolved { get; set; }
}
