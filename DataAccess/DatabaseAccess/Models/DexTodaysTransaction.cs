using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTodaysTransaction
{
    public int Id { get; set; }

    public int? CostId { get; set; }

    public int ClientPpId { get; set; }

    public string DexTableName { get; set; } = null!;

    public int? TransactionId { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime TradeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public int AccountId { get; set; }

    public int? InstrumentId { get; set; }

    public int? TradeTypeId { get; set; }

    public double? Quantity { get; set; }

    public double? Price { get; set; }

    public double? Amount { get; set; }

    public string? Currency { get; set; }

    public string? Comment { get; set; }

    public sbyte? PpTransaction { get; set; }

    public sbyte? CashImpact { get; set; }

    public sbyte? NominalImpact { get; set; }

    public sbyte? Reverse { get; set; }

    public double? AmountAccCur { get; set; }

    public double? ExRate { get; set; }

    public string? Isin { get; set; }

    public int? BankId { get; set; }

    public int? BankCostId { get; set; }

    public int? DepotId { get; set; }

    public string? Depot { get; set; }

    public string? BbTicker { get; set; }

    public string? AccCurrency { get; set; }

    public double? AccExrate { get; set; }

    public double? OpeExrate { get; set; }

    public int? FeeTypeId { get; set; }
}
