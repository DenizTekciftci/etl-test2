using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexBmReturn
{
    public int Id { get; set; }

    public DateTime InputDate { get; set; }

    public DateTime ReturnDate { get; set; }

    public int BmId { get; set; }

    public double BmReturn { get; set; }

    public double BmModDur { get; set; }

    public virtual DexBm Bm { get; set; } = null!;
}
