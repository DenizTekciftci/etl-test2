using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexBankHoldingsInstrument
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public string Currency { get; set; } = null!;

    public int InstrumentId { get; set; }

    public DateTime HoldingDate { get; set; }

    public decimal Quantity { get; set; }

    public virtual DexClientAccount Account { get; set; } = null!;

    public virtual DexCurrency CurrencyNavigation { get; set; } = null!;

    public virtual DexInstrument Instrument { get; set; } = null!;
}
