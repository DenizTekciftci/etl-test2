using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IncomeOverview
{
    public DateTime FeeDate { get; set; }

    public DateTime ValueDate { get; set; }

    public int? DepotId { get; set; }

    public double? FeeNetVat { get; set; }

    public int IncomeBankId { get; set; }

    public int FeeTypeId { get; set; }

    public int? TransactionId { get; set; }

    public string? RiskProfile { get; set; }

    public double? MgmtFee { get; set; }

    public double? PerfFee { get; set; }

    public double? Hurdle { get; set; }
}
