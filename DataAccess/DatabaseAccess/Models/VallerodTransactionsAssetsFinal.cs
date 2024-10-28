using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class VallerodTransactionsAssetsFinal
{
    public DateTime TradeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public int? ClientPpId { get; set; }

    public string? Depot { get; set; }

    public string? SecurityName { get; set; }

    public string? Isin { get; set; }

    public string? Type { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public string Currency { get; set; } = null!;

    public double? ExRateRep { get; set; }

    public double? AmountRepCurrency { get; set; }

    public double? PpCostRepCur { get; set; }

    public double? ThirdPartyCostRepCur { get; set; }

    public string? AssetClassOrSecurityClass { get; set; }
}
