using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class SecurityTransactionsAmountDkk
{
    public int TransactionId { get; set; }

    public DateTime TradeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public int AccountId { get; set; }

    public int InstrumentId { get; set; }

    public int TradeTypeId { get; set; }

    public double Quantity { get; set; }

    public double Price { get; set; }

    public double Amount { get; set; }

    public string Currency { get; set; } = null!;

    public sbyte PpTransaction { get; set; }

    public sbyte Counterpart { get; set; }

    public sbyte CashImpact { get; set; }

    public sbyte NominalImpact { get; set; }

    public sbyte Reverse { get; set; }

    public double? AmountDkk { get; set; }
}
