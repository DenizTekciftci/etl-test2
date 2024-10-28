using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexDividendTransaction
{
    public int TransactionId { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime TradeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public int AccountId { get; set; }

    public int InstrumentId { get; set; }

    public int TradeTypeId { get; set; }

    public double Quantity { get; set; }

    public double Amount { get; set; }

    public string Currency { get; set; } = null!;

    public string? Comment { get; set; }

    public sbyte PpTransaction { get; set; }

    public int CashImpact { get; set; }

    public virtual DexClientAccount Account { get; set; } = null!;

    public virtual DexCurrency CurrencyNavigation { get; set; } = null!;

    public virtual DexInstrument Instrument { get; set; } = null!;

    public virtual DexTradeTypeId TradeType { get; set; } = null!;
}
