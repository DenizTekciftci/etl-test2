using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class AumReturnOverview
{
    public DateTime AumDate { get; set; }

    public int? ClientPpId { get; set; }

    public string? ClientName { get; set; }

    public string? ClientType { get; set; }

    public string? ContractType { get; set; }

    public string? TimeUsed { get; set; }

    public string? Country { get; set; }

    public string? BankExecutionId { get; set; }

    public string? Depot { get; set; }

    public string? DepotTypeDa { get; set; }

    public string? Bank { get; set; }

    public double PpFundDkk { get; set; }

    public double MmFundDkk { get; set; }

    public double AumDkk { get; set; }

    public double InOutDkk { get; set; }

    public double? ReturnPct { get; set; }

    public double? ReturnDkk { get; set; }
}
