using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class BasisMaCashView
{
    public DateTime HoldingDate { get; set; }

    public int? ClientPpId { get; set; }

    public int AccountId { get; set; }

    public double AmountAccCur { get; set; }

    public string? Currency { get; set; }

    public double? AmountDkk { get; set; }
}
