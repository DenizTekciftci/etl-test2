using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class EomReturnDate
{
    /// <summary>
    /// All daily return dates in PP history. Based on dex_dafkast from Access and all prior open days on OMXCSE.
    /// </summary>
    public DateTime ReturnDate { get; set; }
}
