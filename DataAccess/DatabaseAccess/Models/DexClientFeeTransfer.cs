using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientFeeTransfer
{
    public int Id { get; set; }

    public int DepotIdFrom { get; set; }

    public int DepotIdTo { get; set; }
}
