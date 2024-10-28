using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetDeposit
{
    public DateTime TradeDate { get; set; }

    public int? ClientPpId { get; set; }

    public string? ClientName { get; set; }

    public string? Depot { get; set; }

    public string? Account { get; set; }

    public string? Iban { get; set; }

    public double Amount { get; set; }

    public string Currency { get; set; } = null!;
}
