using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientLatestProfile
{
    public int ClientPpId { get; set; }

    public string RiskProfile { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }
}
