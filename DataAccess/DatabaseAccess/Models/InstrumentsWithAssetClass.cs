using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class InstrumentsWithAssetClass
{
    public int InstrumentId { get; set; }

    public string BbTicker { get; set; } = null!;

    public string? Isin { get; set; }

    public string? SecurityName { get; set; }

    public string? Issuer { get; set; }

    public string BpipeReferenceSecurityClass { get; set; } = null!;

    public string? CountryIso { get; set; }

    public string? Currency { get; set; }

    public string? ClassificationLevel1Name { get; set; }

    public string? ClassificationLevel2Name { get; set; }

    public string? ClassificationLevel3Name { get; set; }

    public string? ClassificationLevel4Name { get; set; }

    public string? CpnTyp { get; set; }

    public float? Cpn { get; set; }

    public DateTime? Maturity { get; set; }

    public string? Callable { get; set; }

    public sbyte? IsPerpetual { get; set; }

    public string? BicsLevel1SectorName { get; set; }

    public string? BicsLevel2IndustryGroupName { get; set; }

    public int? GicsSector { get; set; }

    public string? GicsSectorName { get; set; }

    public int? GicsIndustryGroup { get; set; }

    public string? GicsIndustryGroupName { get; set; }

    public int? GicsIndustry { get; set; }

    public string? GicsIndustryName { get; set; }

    public int? GicsSubIndustry { get; set; }

    public string? GicsSubIndustryName { get; set; }

    public string? FundAssetClassFocus { get; set; }

    public string? FundGeoFocus { get; set; }

    public string? FundIndustryFocus { get; set; }

    public string? FundStrategy { get; set; }

    public string? FundMktCapFocus { get; set; }

    public string? FundRtgClassFocus { get; set; }

    public string? HbMaturityBandFocus { get; set; }

    public string? FundMgmtStyle { get; set; }

    public string? FundCrncyFocus { get; set; }

    public float? CpnCap { get; set; }

    public string? Bullet { get; set; }

    public string? SecurityTyp { get; set; }

    public string? ExchCode { get; set; }

    public sbyte Active { get; set; }

    public string AssetClass { get; set; } = null!;
}
