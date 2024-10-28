using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientAccountOverviewBasis
{
    public int AccountId { get; set; }

    public string? Account { get; set; }

    public int DepotId { get; set; }

    public string Currency { get; set; } = null!;

    public string? Iban { get; set; }

    public string? Depot { get; set; }

    public string? BankExecutionId { get; set; }

    public int? DepotTypeId { get; set; }

    public int? BankId { get; set; }

    public int? ClientPpId { get; set; }

    public string? ClientName { get; set; }

    public string? DepotTypeDa { get; set; }

    public string? Bank { get; set; }
}
