using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class TradingBookMonthlyDkkReturn
{
    /// <summary>
    /// All daily return dates in PP history. Based on dex_dafkast from Access and all prior open days on OMXCSE.
    /// </summary>
    public DateTime? ReturnDate { get; set; }

    public int ClientPpId { get; set; }

    public double? DkkReturn { get; set; }
}
