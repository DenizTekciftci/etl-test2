using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexReturnGroup
{
    public int Id { get; set; }

    public string GroupName { get; set; } = null!;

    public int InOutGroup { get; set; }
}
