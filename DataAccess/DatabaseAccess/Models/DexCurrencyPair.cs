using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexCurrencyPair
{
    public string Currency { get; set; } = null!;

    public bool Active { get; set; }

    public string BbTicker { get; set; } = null!;
}
