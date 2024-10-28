using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexManager
{
    public int ManagerId { get; set; }

    public string ManagerName { get; set; } = null!;

    public virtual ICollection<DexClientInfo> DexClientInfos { get; set; } = new List<DexClientInfo>();
}
