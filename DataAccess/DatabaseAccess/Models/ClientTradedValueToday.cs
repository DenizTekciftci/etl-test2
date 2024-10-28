using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientTradedValueToday
{
    public DateTime TradeDate { get; set; }

    public int? ClientPpId { get; set; }

    public string Currency { get; set; } = null!;

    public double? Amount { get; set; }
}
