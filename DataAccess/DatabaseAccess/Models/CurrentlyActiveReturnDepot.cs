using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class CurrentlyActiveReturnDepot
{
    public int DepotId { get; set; }

    public string Active { get; set; } = null!;
}
