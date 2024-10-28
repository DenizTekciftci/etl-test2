using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetIncomeOverview
{
    public int? Year { get; set; }

    public int? Month { get; set; }

    public int? Quarter { get; set; }

    public DateTime FeeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public string? ManagerName { get; set; }

    public int? ClientPpId { get; set; }

    public string? ClientName { get; set; }

    public string? ClientType { get; set; }

    public string? ContractType { get; set; }

    public string? AssetClass { get; set; }

    public string? RiskProfile { get; set; }

    public string? Country { get; set; }

    public string? Depot { get; set; }

    public string? FeeType { get; set; }

    public double? FeeDkk { get; set; }
}
