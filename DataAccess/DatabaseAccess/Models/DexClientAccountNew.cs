using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientAccountNew
{
    public int NewAccountId { get; set; }

    public DateTime InputDate { get; set; }

    public string? Account { get; set; }

    public int? DepotId { get; set; }

    public string? Currency { get; set; }

    public string? Iban { get; set; }

    public int? BankId { get; set; }

    public virtual DexClientDepot? Depot { get; set; }
}
