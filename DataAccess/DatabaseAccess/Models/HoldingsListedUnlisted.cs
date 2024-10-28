using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class HoldingsListedUnlisted
{
    public DateTime HoldingDate { get; set; }

    public int DepotId { get; set; }

    public string? ClientName { get; set; }

    public int? ClientPpId { get; set; }

    public string? BankExecutionId { get; set; }

    public string? Depot { get; set; }

    public string? DepotTypeDa { get; set; }

    public int InstrumentId { get; set; }

    public string? BbTicker { get; set; }

    public string? Isin { get; set; }

    public string? Assets { get; set; }

    public double Quantity { get; set; }

    public double? Price { get; set; }

    public double? IntAcc { get; set; }

    public double? ModDur { get; set; }

    public double? PriceFactor { get; set; }

    public double? PrincipalFactor { get; set; }

    public double? ExRate { get; set; }

    public double? ValueDkk { get; set; }
}
