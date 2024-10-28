using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientActualAumRepCurId
{
    public DateTime AumDate { get; set; }

    public int? ClientPpId { get; set; }

    public double? CashRepCur { get; set; }

    public double? InOutRepCur { get; set; }

    public double? InstRepCur { get; set; }

    public double? TotalAumRepCur { get; set; }
}
