using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class AllClientTransaction
{
    public DateTime TradeDate { get; set; }

    public int? ClientPpId { get; set; }

    public string? BankExecutionId { get; set; }

    public string? Depot { get; set; }

    public string? Account { get; set; }

    public int? DepotId { get; set; }

    public int? InstrumentId { get; set; }

    public string? BbTicker { get; set; }

    public string? Isin { get; set; }

    public string? ClassificationLevel4Name { get; set; }

    public int? TradeTypeId { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public double? Amount { get; set; }

    public string Currency { get; set; } = null!;

    public double? AmountRepCur { get; set; }

    public double? InterestRepCur { get; set; }
}
