using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class MgmtFeeCalcInstHolding
{
    public DateTime HoldingDate { get; set; }

    public int DepotId { get; set; }

    public int InstrumentId { get; set; }

    public int? ClientPpId { get; set; }

    public string? BbTicker { get; set; }

    public string? Isin { get; set; }

    public string? AssetClass { get; set; }

    public string? CountryIso { get; set; }

    public double Quantity { get; set; }

    public double? MarketValueBilCur { get; set; }

    public string? BillingCurrency { get; set; }

    public sbyte? Vat { get; set; }

    public int? IsOnelife { get; set; }

    public double? MgmtFee { get; set; }

    public double? SimpleFiltFee { get; set; }

    public double? InstrumentFiltFee { get; set; }

    public double? CountryFiltFee { get; set; }

    public double? ThematicFee { get; set; }

    public double? MgmtFeeBilCur { get; set; }

    public double? VatBilCur { get; set; }

    public double? MgmtFeeBilCurInclVat { get; set; }
}
