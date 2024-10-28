using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientReturnsDepotReporting
{
    public DateTime ReturnDate { get; set; }

    public int? ClientPpId { get; set; }

    public string? BankExecutionId { get; set; }

    public string? Depot { get; set; }

    public int? DepotId { get; set; }

    public double? RepCurReturnActualExFx { get; set; }

    public double? FxEffectRepCur { get; set; }

    public double? GrossDepotReturnRepCur { get; set; }

    public double? GrossPortfolioAttrReturn { get; set; }

    public double? RepCurReturnActual { get; set; }
}
