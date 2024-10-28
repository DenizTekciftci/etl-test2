using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientReturnsId
{
    public int Id { get; set; }

    public DateTime ReturnDate { get; set; }

    public int ClientPpId { get; set; }

    public double PortfolioReturnActual { get; set; }

    public double PortfolioReturnWCash { get; set; }

    public double PortfolioReturnWoCash { get; set; }

    public sbyte SigIoActualId { get; set; }

    public sbyte SigIoWCashId { get; set; }

    public sbyte SigIoWoCashId { get; set; }

    public double DkkReturnActual { get; set; }

    public double DkkReturnWCash { get; set; }

    public double DkkReturnWoCash { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
