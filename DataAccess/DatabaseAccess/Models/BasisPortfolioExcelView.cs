using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class BasisPortfolioExcelView
{
    public string? BbTicker { get; set; }

    public string? Isin { get; set; }

    public string? SecurityName { get; set; }

    public double? Quantity { get; set; }
}
