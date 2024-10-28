using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientAumDepotReporting
{
    public int Id { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime AumDate { get; set; }

    public int? ClientPpId { get; set; }

    public string? BankExecutionId { get; set; }

    public string? Depot { get; set; }

    public int? DepotId { get; set; }

    public string? DepotType { get; set; }

    public double CashDkk { get; set; }

    public double InstDkk { get; set; }

    public double TotalAumDkk { get; set; }

    public double? CashRepCur { get; set; }

    public double? InstRepCur { get; set; }

    public double? InOut { get; set; }

    public double? TotalAumRepCur { get; set; }
}
