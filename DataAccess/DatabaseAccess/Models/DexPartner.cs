using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexPartner
{
    public int PartnerId { get; set; }

    public string PartnerName { get; set; } = null!;

    public string? PartnerType { get; set; }

    public virtual ICollection<DexClientPartner> DexClientPartners { get; set; } = new List<DexClientPartner>();
}
