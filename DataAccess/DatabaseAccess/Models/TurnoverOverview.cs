using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class TurnoverOverview
{
    public DateTime TradeDate { get; set; }

    public int? DepotId { get; set; }

    public int InstrumentId { get; set; }

    public double? AmountDkk { get; set; }
}
