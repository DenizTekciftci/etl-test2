using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientReturnsIdReporting
{
    public DateTime ReturnDate { get; set; }

    public int ClientPpId { get; set; }

    public double? GrossExRateReturn { get; set; }

    public double? GrossPortfolioReturnRepCur { get; set; }

    public int? BmId { get; set; }

    public double? GrossBmReturnRepCur { get; set; }

    public double? AumDkkT1 { get; set; }

    public double? ExRate { get; set; }

    public double? ExRatePrev { get; set; }

    public double? FxRet { get; set; }

    public double DkkReturnActual { get; set; }

    public double? FxEffectRepCur { get; set; }

    public double? RepCurReturnExFx { get; set; }

    public double? RepCurReturn { get; set; }
}
