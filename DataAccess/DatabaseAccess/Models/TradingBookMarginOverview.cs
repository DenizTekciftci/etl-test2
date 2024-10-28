using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class TradingBookMarginOverview
{
    public int ClientPpId { get; set; }

    public string? ClientName { get; set; }

    public string? ClientType { get; set; }

    public string? ContractType { get; set; }

    public double? Realkreditobligationer { get; set; }

    public double? Statsobligationer { get; set; }

    public double? Kreditobligationer { get; set; }

    public double? Alternativer { get; set; }

    public double? Equity { get; set; }
}
