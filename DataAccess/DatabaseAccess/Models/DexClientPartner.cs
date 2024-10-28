using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientPartner
{
    public int Id { get; set; }

    public int ClientPpId { get; set; }

    public int PartnerId { get; set; }

    public sbyte IsFeeSharing { get; set; }

    public string? FeeSharingFrequency { get; set; }

    public virtual DexClientInfo ClientPp { get; set; } = null!;

    public virtual DexPartner Partner { get; set; } = null!;
}
