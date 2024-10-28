using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientInfo
{
    public int ClientPpId { get; set; }

    public string ClientName { get; set; } = null!;

    public string? Address { get; set; }

    public string? Zip { get; set; }

    public string? City { get; set; }

    public int CountryId { get; set; }

    public string? Cvr { get; set; }

    public string? ContractType { get; set; }

    public string? ClientType { get; set; }

    public string? TimeUsed { get; set; }

    public int ManagerId { get; set; }

    public string BillingCurrency { get; set; } = null!;

    public virtual DexCountry Country { get; set; } = null!;

    public virtual ICollection<DexClientAllocLimit> DexClientAllocLimits { get; set; } = new List<DexClientAllocLimit>();

    public virtual ICollection<DexClientAssetClassAlloc> DexClientAssetClassAllocs { get; set; } = new List<DexClientAssetClassAlloc>();

    public virtual ICollection<DexClientAumId> DexClientAumIds { get; set; } = new List<DexClientAumId>();

    public virtual ICollection<DexClientBenchmark> DexClientBenchmarks { get; set; } = new List<DexClientBenchmark>();

    public virtual ICollection<DexClientContact> DexClientContacts { get; set; } = new List<DexClientContact>();

    public virtual ICollection<DexClientCountryAlloc> DexClientCountryAllocs { get; set; } = new List<DexClientCountryAlloc>();

    public virtual ICollection<DexClientCouponAlloc> DexClientCouponAllocs { get; set; } = new List<DexClientCouponAlloc>();

    public virtual ICollection<DexClientDepot> DexClientDepots { get; set; } = new List<DexClientDepot>();

    public virtual ICollection<DexClientDepotsNew> DexClientDepotsNews { get; set; } = new List<DexClientDepotsNew>();

    public virtual ICollection<DexClientFeeCap> DexClientFeeCaps { get; set; } = new List<DexClientFeeCap>();

    public virtual ICollection<DexClientFtNumber> DexClientFtNumbers { get; set; } = new List<DexClientFtNumber>();

    public virtual ICollection<DexClientMarginStructure> DexClientMarginStructures { get; set; } = new List<DexClientMarginStructure>();

    public virtual ICollection<DexClientPartner> DexClientPartners { get; set; } = new List<DexClientPartner>();

    public virtual ICollection<DexClientProfile> DexClientProfiles { get; set; } = new List<DexClientProfile>();

    public virtual ICollection<DexClientReporting> DexClientReportings { get; set; } = new List<DexClientReporting>();

    public virtual ICollection<DexClientReturnsId> DexClientReturnsIds { get; set; } = new List<DexClientReturnsId>();

    public virtual ICollection<DexClientSectorAlloc> DexClientSectorAllocs { get; set; } = new List<DexClientSectorAlloc>();

    public virtual DexManager Manager { get; set; } = null!;
}
