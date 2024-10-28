using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetClientOverview
{
    public int ClientPpId { get; set; }

    public string ClientName { get; set; } = null!;

    public string? ContractType { get; set; }

    public string? ClientType { get; set; }

    public string? Country { get; set; }

    public string Aktiv { get; set; } = null!;
}
