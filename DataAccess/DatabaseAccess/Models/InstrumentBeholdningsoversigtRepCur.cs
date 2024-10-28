using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class InstrumentBeholdningsoversigtRepCur
{
    public DateTime HoldingDate { get; set; }

    public int? ClientPpId { get; set; }

    public string? Depot { get; set; }

    public string? SecurityName { get; set; }

    public string? Isin { get; set; }

    public double Quantity { get; set; }

    public double? Price { get; set; }

    public double? PrincipalFactor { get; set; }

    public double? IntAcc { get; set; }

    public double? ModDur { get; set; }

    public string? Currency { get; set; }

    public double? ValueReportingCurrency { get; set; }

    public double? Weight { get; set; }

    public string? AktivType { get; set; }
}
