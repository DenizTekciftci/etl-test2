using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class BasisTransactionsExcelView
{
    public int TransactionId { get; set; }

    public DateTime TradeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public string? TradeTypeName { get; set; }

    public string? BbTicker { get; set; }

    public string? Isin { get; set; }

    public string? SecurityName { get; set; }

    public double Quantity { get; set; }

    public double Price { get; set; }

    public double Amount { get; set; }

    public string Currency { get; set; } = null!;
}
