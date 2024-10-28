using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientCashHolding
{
    public int Id { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime HoldingDate { get; set; }

    public int AccountId { get; set; }

    public double AmountAccCur { get; set; }

    public virtual DexClientAccount Account { get; set; } = null!;
}
