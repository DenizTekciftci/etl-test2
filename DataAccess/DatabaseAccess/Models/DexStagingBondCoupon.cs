using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexStagingBondCoupon
{
    public int StagingTransactionId { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime TradeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public int? AccountId { get; set; }

    public string Account { get; set; } = null!;

    public int? InstrumentId { get; set; }

    public string Isin { get; set; } = null!;

    public int? TradeTypeId { get; set; }

    public string TradeTypeName { get; set; } = null!;

    public double Amount { get; set; }

    public string Currency { get; set; } = null!;

    public string? Comment { get; set; }

    public sbyte PpTransaction { get; set; }

    public sbyte CashImpact { get; set; }

    public int Processed { get; set; }

    public virtual DexClientAccount? AccountNavigation { get; set; }

    public virtual DexCurrency CurrencyNavigation { get; set; } = null!;

    public virtual DexInstrument? Instrument { get; set; }

    public virtual DexTradeTypeId? TradeType { get; set; }
}
