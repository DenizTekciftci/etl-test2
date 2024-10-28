using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetClientAumDepot
{
    public DateTime AumDate { get; set; }

    public int DepotId { get; set; }

    public double? CashRepCur { get; set; }

    public double? InOutRepCur { get; set; }

    public double? InstRepCur { get; set; }

    public double? TotalAumRepCur { get; set; }

    public int? ClientPpId { get; set; }

    public string? DepotTypeDa { get; set; }
}
