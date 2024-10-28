using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientReturnsDepot
{
    public int Id { get; set; }

    public DateTime ReturnDate { get; set; }

    public int DepotId { get; set; }

    public double WActual { get; set; }

    public double WWCash { get; set; }

    public double WWoCash { get; set; }

    public double DepotReturnActual { get; set; }

    public double DepotReturnWCash { get; set; }

    public double DepotReturnWoCash { get; set; }

    /// <summary>
    /// Depending on return group on given return date, this column will correspond to either PORTFOLIO_RETURN_ATTR_W_CASH or PORTFOLIO_RETURN_ATTR_WO_CASH
    /// </summary>
    public double PortfolioReturnAttrActual { get; set; }

    public double PortfolioReturnAttrWCash { get; set; }

    public double PortfolioReturnAttrWoCash { get; set; }

    public sbyte SigIoActualDepot { get; set; }

    public sbyte SigIoWCashDepot { get; set; }

    public sbyte SigIoWoCashDepot { get; set; }

    public double DkkReturnActual { get; set; }

    public double DkkReturnWCash { get; set; }

    public double DkkReturnWoCash { get; set; }

    public virtual DexClientDepot Depot { get; set; } = null!;
}
