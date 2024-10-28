using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTransactionTable
{
    public int DexTableId { get; set; }

    public string? DexTableName { get; set; }
}
