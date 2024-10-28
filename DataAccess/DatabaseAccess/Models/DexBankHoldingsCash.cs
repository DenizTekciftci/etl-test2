using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexBankHoldingsCash
{
    public int Id { get; set; }

    public int AccountId { get; set; }

    public string Currency { get; set; } = null!;

    public DateTime HoldingDate { get; set; }

    public decimal Amount { get; set; }

    public virtual DexClientAccount Account { get; set; } = null!;

    public virtual DexCurrency CurrencyNavigation { get; set; } = null!;
}
