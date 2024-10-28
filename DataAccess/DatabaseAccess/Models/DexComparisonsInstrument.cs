using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexComparisonsInstrument
{
    public int Id { get; set; }

    public DateTime? InputDate { get; set; }

    public DateTime? HoldingDate { get; set; }

    public int DepotId { get; set; }

    public decimal? PpQuantity { get; set; }

    public decimal? BankQuantity { get; set; }

    public decimal? Value { get; set; }

    public int InstrumentId { get; set; }

    public decimal? Diff { get; set; }

    public ulong Resolved { get; set; }
}
