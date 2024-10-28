using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class FundReturn
{
    public DateTime PriceDate { get; set; }

    public string? BbTicker { get; set; }

    public string? Isin { get; set; }

    public double Price { get; set; }

    public double InstReturn { get; set; }
}
