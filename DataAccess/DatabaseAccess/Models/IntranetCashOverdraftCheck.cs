using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetCashOverdraftCheck
{
    public DateTime HoldingDate { get; set; }

    public int? ClientPpId { get; set; }

    public string? ClientName { get; set; }

    public string? Bank { get; set; }

    public string? DepotTypeDa { get; set; }

    public string? Depot { get; set; }

    public string? Account { get; set; }

    public string? Iban { get; set; }

    public double AmountAccCur { get; set; }

    public string? Currency { get; set; }
}
