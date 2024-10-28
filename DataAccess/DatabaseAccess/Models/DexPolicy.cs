using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexPolicy
{
    public int Id { get; set; }

    public string PolicyId { get; set; } = null!;

    public string? ApplicationId { get; set; }

    public int ClientPpId { get; set; }

    public string Depot { get; set; } = null!;

    public sbyte Active { get; set; }

    public string Account { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string Location { get; set; } = null!;

    public int AccountId { get; set; }

    public virtual DexClientAccount AccountNavigation { get; set; } = null!;

    public virtual DexCurrency CurrencyNavigation { get; set; } = null!;
}
