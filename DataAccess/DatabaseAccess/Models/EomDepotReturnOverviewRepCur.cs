using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class EomDepotReturnOverviewRepCur
{
    public int? DepotId { get; set; }

    /// <summary>
    /// All daily return dates in PP history. Based on dex_dafkast from Access and all prior open days on OMXCSE.
    /// </summary>
    public DateTime? ReturnDate { get; set; }

    public double? GrossDepotReturnRepCur { get; set; }

    public double? GrossPortfolioAttrReturn { get; set; }

    public double? RepCurReturnActual { get; set; }
}
