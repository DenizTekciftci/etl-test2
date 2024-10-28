using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexCountry
{
    public int Id { get; set; }

    public string? Country { get; set; }

    public string? ShortName { get; set; }

    public string? Iso { get; set; }

    public virtual ICollection<DexClientInfo> DexClientInfos { get; set; } = new List<DexClientInfo>();
}
