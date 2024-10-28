using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class AllocationInfo
{
    public int AccountId { get; set; }

    public string? Account { get; set; }

    public string? Iban { get; set; }

    public int? ClientPpId { get; set; }

    public string? Bank { get; set; }
}
