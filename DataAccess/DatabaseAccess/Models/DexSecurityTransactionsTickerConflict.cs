using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexSecurityTransactionsTickerConflict
{
    public int Id { get; set; }

    public int TransactionId { get; set; }

    public DateTime? InputDate { get; set; }

    public DateTime? TradeDate { get; set; }

    public DateTime? ValueDate { get; set; }

    public int? AccountId { get; set; }

    public string? Depot { get; set; }

    public int? InstrumentId { get; set; }

    public int? TradeTypeId { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public double? Amount { get; set; }

    public string? Currency { get; set; }
}
