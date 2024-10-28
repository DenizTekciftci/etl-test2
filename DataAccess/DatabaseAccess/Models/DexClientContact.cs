using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientContact
{
    public int Id { get; set; }

    public int ClientPpId { get; set; }

    public string ContactFirstName { get; set; } = null!;

    public string? ContactFullName { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPhone { get; set; }

    public int ReceiveReporting { get; set; }

    public int Active { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;
}
