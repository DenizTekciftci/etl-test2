using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexClientAccount
{
    public int AccountId { get; set; }

    public string? Account { get; set; }

    public int DepotId { get; set; }

    public string Currency { get; set; } = null!;

    public string? Iban { get; set; }

    public virtual DexCurrency CurrencyNavigation { get; set; } = null!;

    public virtual DexClientDepot Depot { get; set; } = null!;

    public virtual ICollection<DexBankHoldingsCash> DexBankHoldingsCashes { get; set; } = new List<DexBankHoldingsCash>();

    public virtual ICollection<DexBankHoldingsInstrument> DexBankHoldingsInstruments { get; set; } = new List<DexBankHoldingsInstrument>();

    public virtual ICollection<DexBondCoupon> DexBondCoupons { get; set; } = new List<DexBondCoupon>();

    public virtual ICollection<DexCashTransaction> DexCashTransactions { get; set; } = new List<DexCashTransaction>();

    public virtual ICollection<DexClientCashHolding> DexClientCashHoldings { get; set; } = new List<DexClientCashHolding>();

    public virtual ICollection<DexCost> DexCosts { get; set; } = new List<DexCost>();

    public virtual ICollection<DexDividendTransaction> DexDividendTransactions { get; set; } = new List<DexDividendTransaction>();

    public virtual ICollection<DexMgmtPerfFee> DexMgmtPerfFees { get; set; } = new List<DexMgmtPerfFee>();

    public virtual ICollection<DexPolicy> DexPolicies { get; set; } = new List<DexPolicy>();

    public virtual ICollection<DexSecurityTransaction> DexSecurityTransactions { get; set; } = new List<DexSecurityTransaction>();

    public virtual ICollection<DexStagingBondCoupon> DexStagingBondCoupons { get; set; } = new List<DexStagingBondCoupon>();

    public virtual ICollection<DexStagingCashTransaction> DexStagingCashTransactions { get; set; } = new List<DexStagingCashTransaction>();

    public virtual ICollection<DexStagingCost> DexStagingCosts { get; set; } = new List<DexStagingCost>();

    public virtual ICollection<DexStagingDividendTransaction> DexStagingDividendTransactions { get; set; } = new List<DexStagingDividendTransaction>();

    public virtual ICollection<DexStagingSecurityTransaction> DexStagingSecurityTransactions { get; set; } = new List<DexStagingSecurityTransaction>();
}
