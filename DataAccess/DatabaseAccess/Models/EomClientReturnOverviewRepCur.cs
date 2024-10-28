using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class EomClientReturnOverviewRepCur
{
    public int ClientPpId { get; set; }

    /// <summary>
    /// All daily return dates in PP history. Based on dex_dafkast from Access and all prior open days on OMXCSE.
    /// </summary>
    public DateTime? ReturnDate { get; set; }

    public double? GrossPortfolioReturnRepCur { get; set; }

    public double? GrossBmReturnRepCur { get; set; }

    public double? DkkReturnActual { get; set; }

    public double? RepCurReturn { get; set; }
}
