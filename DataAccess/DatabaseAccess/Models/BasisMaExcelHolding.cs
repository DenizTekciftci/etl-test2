using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class BasisMaExcelHolding
{
    public DateTime HoldingDate { get; set; }

    public int? ClientPpId { get; set; }

    public int InstrumentId { get; set; }

    public string? BbTicker { get; set; }

    public string? Isin { get; set; }

    public string? BpipeReferenceSecurityClass { get; set; }

    public double Quantity { get; set; }

    public double? ValueDkk { get; set; }
}
