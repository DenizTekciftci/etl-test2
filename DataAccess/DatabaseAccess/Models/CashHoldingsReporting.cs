using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class CashHoldingsReporting
{
    public string? Bank { get; set; }

    public DateTime HoldingDate { get; set; }

    public int? ClientPpId { get; set; }

    public string? BankExecutionId { get; set; }

    public string? Depot { get; set; }

    public string? Account { get; set; }

    public int AccountId { get; set; }

    public string? Currency { get; set; }

    public double? ExRate { get; set; }

    public double AmountAccCur { get; set; }

    public double? ValueDkk { get; set; }

    public double? ValueReportingCurrency { get; set; }

    public int? ReturnGroup { get; set; }
}
