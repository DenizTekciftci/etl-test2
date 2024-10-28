using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class CashTransactionsView
{
    public int? ClientPpId { get; set; }

    public string? BankExecutionId { get; set; }

    public string? Depot { get; set; }

    public string? Account { get; set; }

    public int TransactionId { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime TradeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public int AccountId { get; set; }

    public int TradeTypeId { get; set; }

    public double Amount { get; set; }

    public string Currency { get; set; } = null!;

    public string? Comment { get; set; }

    public int PpTransaction { get; set; }

    public int CashImpact { get; set; }
}
