using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class AumToday
{
    public DateTime AumDate { get; set; }

    public int? ClientPpId { get; set; }

    public double? CashDkk { get; set; }

    public double? InOutDkk { get; set; }

    public double? InstDkk { get; set; }

    public double? TotalAumDkk { get; set; }
}
