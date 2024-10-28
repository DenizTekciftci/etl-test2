using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexCost
{
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

    public virtual DexClientAccount Account { get; set; } = null!;

    public virtual DexBankCost BankCost { get; set; } = null!;

    public virtual DexCurrency CurrencyNavigation { get; set; } = null!;

    public virtual DexTradeTypeId TradeType { get; set; } = null!;
}
