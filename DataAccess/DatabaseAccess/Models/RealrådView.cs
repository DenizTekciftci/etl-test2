using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class RealrådView
{
    public int TransactionId { get; set; }

    public int? ClientPpId { get; set; }

    public DateTime TradeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public int TradeTypeId { get; set; }

    public double Quantity { get; set; }

    public string? Isin { get; set; }

    public string? SecurityName { get; set; }

    public double Price { get; set; }

    public double? PricePp { get; set; }

    public double? ExRate { get; set; }

    public double Amount { get; set; }

    /// <summary>
    /// Provided in positive terms, to reflect income for PP
    /// </summary>
    public double? Indtjening { get; set; }

    public double? Omkostning { get; set; }

    public string? Comment { get; set; }

    public double? AmountPp { get; set; }
}
