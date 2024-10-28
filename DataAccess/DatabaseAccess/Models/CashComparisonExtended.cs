using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class CashComparisonExtended
{
    public int Id { get; set; }

    public DateTime? InputDate { get; set; }

    public DateTime? HoldingDate { get; set; }

    public decimal? PpAmount { get; set; }

    public decimal? BankAmount { get; set; }

    public int? ClientPpId { get; set; }

    public string? Depot { get; set; }

    public string? Account { get; set; }

    public int? AccountId { get; set; }

    public decimal? Value { get; set; }

    public string? Currency { get; set; }

    public decimal? Diff { get; set; }

    public string? BankExecutionId { get; set; }

    public sbyte Resolved { get; set; }

    public string? Bank { get; set; }

    public string? ClientName { get; set; }

    public string? DepotTypeDa { get; set; }
}
