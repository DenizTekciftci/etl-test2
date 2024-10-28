using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexContact
{
    public int ContactId { get; set; }

    public string ContactFirstName { get; set; } = null!;

    public string? ContactFullName { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPhone { get; set; }
}
