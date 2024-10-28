using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class ClientActualAumDkkDepot
{
    public DateTime AumDate { get; set; }

    public int DepotId { get; set; }

    public double CashDkk { get; set; }

    public double InOutDkk { get; set; }

    public double InstDkk { get; set; }

    public double TotalAumDkk { get; set; }
}
