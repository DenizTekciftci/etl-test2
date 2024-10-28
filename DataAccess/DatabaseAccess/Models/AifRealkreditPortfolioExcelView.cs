using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class AifRealkreditPortfolioExcelView
{
    public string? Isin { get; set; }

    public string? SecurityName { get; set; }

    public double? Quantity { get; set; }
}
