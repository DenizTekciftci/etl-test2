using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ReturnGroupOverview
{
    public int IdReturnGroup { get; set; }

    public int? ClientPpId { get; set; }

    public string? ClientName { get; set; }

    public int? DepotId { get; set; }

    public string? BankExecutionId { get; set; }

    public string? Depot { get; set; }

    public string? DepotTypeDa { get; set; }

    public int ReturnGroup { get; set; }

    public string? GroupName { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}
