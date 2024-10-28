using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class MgmtFeeCalcCashHolding
{
    public DateTime HoldingDate { get; set; }

    public int? ClientPpId { get; set; }

    public int? DepotId { get; set; }

    public double? CashBilCur { get; set; }

    public string? BillingCurrency { get; set; }

    public double? MgmtFee { get; set; }

    public double? MgmtFeeCashFilter { get; set; }

    public sbyte? Vat { get; set; }

    public long IsOnelife { get; set; }

    public double? MgmtFeeBilCur { get; set; }

    public double? VatBilCur { get; set; }

    public double? MgmtFeeBilCurInclVat { get; set; }
}
