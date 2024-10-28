using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class LastestInstrumentValuationRepCur
{
    public DateTime HoldingDate { get; set; }

    public int? ClientPpId { get; set; }

    public string? BankExecutionId { get; set; }

    public string? Depot { get; set; }

    public int DepotId { get; set; }

    public int InstrumentId { get; set; }

    public double Quantity { get; set; }

    public string? BbTicker { get; set; }

    public string? Isin { get; set; }

    public string? SecurityName { get; set; }

    public string? BpipeReferenceSecurityClass { get; set; }

    public string? Currency { get; set; }

    public double? Price { get; set; }

    public double? IntAcc { get; set; }

    public double? ModDur { get; set; }

    public double? PriceFactor { get; set; }

    public double? PrincipalFactor { get; set; }

    public double? ValueLoc { get; set; }

    public double? ValueReportingCurrency { get; set; }

    public string? DepotType { get; set; }
}
