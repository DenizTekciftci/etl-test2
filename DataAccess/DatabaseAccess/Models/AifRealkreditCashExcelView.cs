using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class AifRealkreditCashExcelView
{
    public int AccountId { get; set; }

    public double AmountAccCur { get; set; }

    public string? Currency { get; set; }
}
