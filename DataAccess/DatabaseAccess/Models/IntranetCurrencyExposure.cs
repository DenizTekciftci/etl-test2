using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetCurrencyExposure
{
    public int? ClientPpId { get; set; }

    public string? Currency { get; set; }

    public double? Weight { get; set; }
}
