using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetAumDashboard
{
    public DateTime AumDate { get; set; }

    public string? ClientType { get; set; }

    public double? AumDkk { get; set; }

    public double? InOutDkk { get; set; }
}
