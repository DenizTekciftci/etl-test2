using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class CostsView
{
    public int? ClientPpId { get; set; }

    public string? BankExecutionId { get; set; }

    public string? Depot { get; set; }

    public string? Account { get; set; }

    public string? BankCostName { get; set; }

    public string? CostTypeName { get; set; }

    public int Id { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime TradeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public int AccountId { get; set; }

    public int TradeTypeId { get; set; }

    public int DexTableId { get; set; }

    public int TransactionId { get; set; }

    public int BankCostId { get; set; }

    public double Amount { get; set; }

    public string Currency { get; set; } = null!;

    public int CashImpact { get; set; }

    public sbyte PpTransaction { get; set; }

    public sbyte? AddToCostOverview { get; set; }
}
