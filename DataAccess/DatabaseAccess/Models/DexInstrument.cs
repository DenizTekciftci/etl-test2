using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexInstrument
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

    public sbyte Listed { get; set; }

    public virtual ICollection<DexBankHoldingsInstrument> DexBankHoldingsInstruments { get; set; } = new List<DexBankHoldingsInstrument>();

    public virtual ICollection<DexBmWeight> DexBmWeights { get; set; } = new List<DexBmWeight>();

    public virtual ICollection<DexBondCoupon> DexBondCoupons { get; set; } = new List<DexBondCoupon>();

    public virtual ICollection<DexClientInstHolding> DexClientInstHoldings { get; set; } = new List<DexClientInstHolding>();

    public virtual ICollection<DexDividendTransaction> DexDividendTransactions { get; set; } = new List<DexDividendTransaction>();

    public virtual ICollection<DexFundCode> DexFundCodes { get; set; } = new List<DexFundCode>();

    public virtual ICollection<DexFundÅop> DexFundÅops { get; set; } = new List<DexFundÅop>();

    public virtual ICollection<DexInstrumentCntryAlloc> DexInstrumentCntryAllocs { get; set; } = new List<DexInstrumentCntryAlloc>();

    public virtual ICollection<DexInstrumentMcapAlloc> DexInstrumentMcapAllocs { get; set; } = new List<DexInstrumentMcapAlloc>();

    public virtual ICollection<DexInstrumentPrice> DexInstrumentPrices { get; set; } = new List<DexInstrumentPrice>();

    public virtual ICollection<DexInstrumentSectorAlloc> DexInstrumentSectorAllocs { get; set; } = new List<DexInstrumentSectorAlloc>();

    public virtual ICollection<DexPeCommitment> DexPeCommitments { get; set; } = new List<DexPeCommitment>();

    public virtual ICollection<DexPpFundAssetClassAlloc> DexPpFundAssetClassAllocs { get; set; } = new List<DexPpFundAssetClassAlloc>();

    public virtual ICollection<DexSecurityTransaction> DexSecurityTransactions { get; set; } = new List<DexSecurityTransaction>();

    public virtual ICollection<DexStagingBondCoupon> DexStagingBondCoupons { get; set; } = new List<DexStagingBondCoupon>();

    public virtual ICollection<DexStagingDividendTransaction> DexStagingDividendTransactions { get; set; } = new List<DexStagingDividendTransaction>();

    public virtual ICollection<DexStagingSecurityTransaction> DexStagingSecurityTransactions { get; set; } = new List<DexStagingSecurityTransaction>();
}
