using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexExchangeRate
{
    public int Id { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime ExRateDate { get; set; }

    public string Currency { get; set; } = null!;

    public double ExRate { get; set; }
}
