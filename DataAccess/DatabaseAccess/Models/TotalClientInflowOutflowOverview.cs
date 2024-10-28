using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class TotalClientInflowOutflowOverview
{
    public int? ClientPpId { get; set; }

    public DateTime? StartDate { get; set; }

    public double? InflowOutflow { get; set; }
}
