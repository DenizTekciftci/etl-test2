using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientReporting
{
    public int Id { get; set; }

    public int ClientPpId { get; set; }

    public string ReportingCurrency { get; set; } = null!;

    public sbyte MergeRealerStater { get; set; }

    public int FiscalYearEnd { get; set; }

    public int QuarterlyReporting { get; set; }

    public sbyte WantReporting { get; set; }

    public sbyte WantExcel { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
