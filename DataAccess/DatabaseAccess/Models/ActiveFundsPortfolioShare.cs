using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ActiveFundsPortfolioShare
{
    public int ClientPpId { get; set; }

    public int InstrumentId { get; set; }

    public string? Isin { get; set; }

    public string BbTicker { get; set; } = null!;

    public string? SecurityName { get; set; }

    public double Quantity { get; set; }

    public double Price { get; set; }

    public double ValueDkk { get; set; }

    public double? PortfolioSharePercent { get; set; }
}
