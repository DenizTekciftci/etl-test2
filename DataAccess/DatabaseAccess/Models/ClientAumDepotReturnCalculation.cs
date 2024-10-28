using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientAumDepotReturnCalculation
{
    public DateTime AumDate { get; set; }

    public int DepotId { get; set; }

    public int? ClientPpId { get; set; }

    public string? BankExecutionId { get; set; }

    public string? Depot { get; set; }

    public double CashDkkDepot { get; set; }

    public double PpFundDkk { get; set; }

    public double MmFundDkk { get; set; }

    public double IoDkkWCashDepot { get; set; }

    public double IoDkkWoCashDepot { get; set; }

    public double IoDkkActualDepot { get; set; }

    public int? ReturnGroup { get; set; }

    public double AumDkkWoCashDepot { get; set; }

    public double AumDkkWCashDepot { get; set; }

    public double AumDkkActualDepot { get; set; }
}
