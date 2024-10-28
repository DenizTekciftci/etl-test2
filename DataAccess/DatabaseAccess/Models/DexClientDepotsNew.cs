using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientDepotsNew
{
    public int NewDepotId { get; set; }

    public DateTime InputDate { get; set; }

    public string? Depot { get; set; }

    public string? BankExecutionId { get; set; }

    public int? BankId { get; set; }

    public int? DepotTypeId { get; set; }

    public int? ClientPpId { get; set; }

    public virtual DexBank? Bank { get; set; }

    public virtual DexClientInfo? ClientPp { get; set; }

    public virtual DexDepotType? DepotType { get; set; }
}
