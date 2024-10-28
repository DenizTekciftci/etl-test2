using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientDepot
{
    public int DepotId { get; set; }

    public string? Depot { get; set; }

    public string? BankExecutionId { get; set; }

    public int DepotTypeId { get; set; }

    public int BankId { get; set; }

    public int ClientPpId { get; set; }

    public int Recalculate { get; set; }

    public DateTime? RecalculateFromDate { get; set; }

    public virtual DexBank Bank { get; set; } = null!;

    public virtual DexClientInfo ClientPp { get; set; } = null!;

    public virtual DexDepotType DepotType { get; set; } = null!;

    public virtual ICollection<DexClientAccountNew> DexClientAccountNews { get; set; } = new List<DexClientAccountNew>();

    public virtual ICollection<DexClientAccount> DexClientAccounts { get; set; } = new List<DexClientAccount>();

    public virtual ICollection<DexClientAumDepot> DexClientAumDepots { get; set; } = new List<DexClientAumDepot>();

    public virtual ICollection<DexClientDepotDate> DexClientDepotDates { get; set; } = new List<DexClientDepotDate>();

    public virtual ICollection<DexClientFeeFilter> DexClientFeeFilters { get; set; } = new List<DexClientFeeFilter>();

    public virtual ICollection<DexClientFeeStructure> DexClientFeeStructures { get; set; } = new List<DexClientFeeStructure>();

    public virtual ICollection<DexClientInstHolding> DexClientInstHoldings { get; set; } = new List<DexClientInstHolding>();

    public virtual ICollection<DexClientReturnGroup> DexClientReturnGroups { get; set; } = new List<DexClientReturnGroup>();

    public virtual ICollection<DexClientReturnsDepot> DexClientReturnsDepots { get; set; } = new List<DexClientReturnsDepot>();

    public virtual ICollection<DexClientVat> DexClientVats { get; set; } = new List<DexClientVat>();

    public virtual ICollection<DexPeCommitment> DexPeCommitments { get; set; } = new List<DexPeCommitment>();
}
