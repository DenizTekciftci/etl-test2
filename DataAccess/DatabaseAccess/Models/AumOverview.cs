using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class AumOverview
{
    public DateTime AumDate { get; set; }

    public int DepotId { get; set; }

    public double? MgmtFee { get; set; }

    public double? PerformanceFee { get; set; }

    public double? Hurdle { get; set; }

    public double PpFundDkk { get; set; }

    public double MmFundDkk { get; set; }

    public double AumDkk { get; set; }

    public double AumExPpFundDkk { get; set; }

    public double? InOutDkk { get; set; }
}
