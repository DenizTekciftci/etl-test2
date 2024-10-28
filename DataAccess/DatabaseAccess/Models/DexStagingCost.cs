using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexStagingCost
{
    public int StagingId { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime TradeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public int? AccountId { get; set; }

    public string Account { get; set; } = null!;

    public int? TradeTypeId { get; set; }

    public string TradeTypeName { get; set; } = null!;

    public int DexTableId { get; set; }

    public int StagingTransactionId { get; set; }

    public string StagingTableRef { get; set; } = null!;

    public int? BankCostId { get; set; }

    public double Amount { get; set; }

    public string Currency { get; set; } = null!;

    public int CashImpact { get; set; }

    public sbyte PpTransaction { get; set; }

    public int Processed { get; set; }

    public virtual DexClientAccount? AccountNavigation { get; set; }

    public virtual DexBankCost? BankCost { get; set; }

    public virtual DexCurrency CurrencyNavigation { get; set; } = null!;

    public virtual DexTradeTypeId? TradeType { get; set; }
}
