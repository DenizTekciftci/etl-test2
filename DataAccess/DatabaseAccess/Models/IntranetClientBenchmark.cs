using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class IntranetClientBenchmark
{
    public int Id { get; set; }

    public int ClientPpId { get; set; }

    public string? ClientName { get; set; }

    public int BmId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? BmName { get; set; }
}
