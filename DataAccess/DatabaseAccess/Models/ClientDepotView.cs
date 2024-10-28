using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientDepotView
{
    public int DepotId { get; set; }

    public string? Depot { get; set; }

    public string? BankExecutionId { get; set; }

    public int DepotTypeId { get; set; }

    public int BankId { get; set; }

    public int ClientPpId { get; set; }

    public string? Active { get; set; }
}
