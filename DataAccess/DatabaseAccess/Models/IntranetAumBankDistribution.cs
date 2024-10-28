using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetAumBankDistribution
{
    public string? Bank { get; set; }

    public long Clients { get; set; }

    public double? AlmBolig { get; set; }

    public double? Pengeinstitut { get; set; }

    public double? Balanceret { get; set; }

    public double? Investeringsforening { get; set; }

    public double? TotalAum { get; set; }
}
