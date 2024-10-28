using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientAumIdEomView
{
    public DateTime AumDate { get; set; }

    public int? ClientPpId { get; set; }

    public double? CashDkk { get; set; }

    public double? InstDkk { get; set; }

    public double? PpFundDkk { get; set; }

    public double? MmFundDkk { get; set; }

    public double? AumDkk { get; set; }

    public double? InOutDkk { get; set; }

    public int FundsOnly { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }
}
