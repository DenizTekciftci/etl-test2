using System;
using System.Collections.Generic;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTradeTypeId
{
    public int TradeTypeId { get; set; }

    public string TradeTypeName { get; set; } = null!;

    public int? DexTableId { get; set; }

    public string TradeTypeNameDa { get; set; } = null!;

    public virtual ICollection<DexAccessTradeId> DexAccessTradeIds { get; set; } = new List<DexAccessTradeId>();

    public virtual ICollection<DexBondCoupon> DexBondCoupons { get; set; } = new List<DexBondCoupon>();

    public virtual ICollection<DexCashTransaction> DexCashTransactions { get; set; } = new List<DexCashTransaction>();

    public virtual ICollection<DexCost> DexCosts { get; set; } = new List<DexCost>();

    public virtual ICollection<DexDividendTransaction> DexDividendTransactions { get; set; } = new List<DexDividendTransaction>();

    public virtual ICollection<DexSecurityTransaction> DexSecurityTransactions { get; set; } = new List<DexSecurityTransaction>();

    public virtual ICollection<DexStagingBondCoupon> DexStagingBondCoupons { get; set; } = new List<DexStagingBondCoupon>();

    public virtual ICollection<DexStagingCashTransaction> DexStagingCashTransactions { get; set; } = new List<DexStagingCashTransaction>();

    public virtual ICollection<DexStagingCost> DexStagingCosts { get; set; } = new List<DexStagingCost>();

    public virtual ICollection<DexStagingDividendTransaction> DexStagingDividendTransactions { get; set; } = new List<DexStagingDividendTransaction>();

    public virtual ICollection<DexStagingSecurityTransaction> DexStagingSecurityTransactions { get; set; } = new List<DexStagingSecurityTransaction>();

    public virtual ICollection<DexTradeTypeBil> DexTradeTypeBils { get; set; } = new List<DexTradeTypeBil>();

    public virtual ICollection<DexTradeTypeEfg> DexTradeTypeEfgs { get; set; } = new List<DexTradeTypeEfg>();

    public virtual ICollection<DexTradeTypeJyske> DexTradeTypeJyskes { get; set; } = new List<DexTradeTypeJyske>();

    public virtual ICollection<DexTradeTypeNew> DexTradeTypeNews { get; set; } = new List<DexTradeTypeNew>();

    public virtual ICollection<DexTradeTypeNordnet> DexTradeTypeNordnets { get; set; } = new List<DexTradeTypeNordnet>();

    public virtual ICollection<DexTradeTypeRilba> DexTradeTypeRilbas { get; set; } = new List<DexTradeTypeRilba>();

    public virtual ICollection<DexTradeTypeSaxo> DexTradeTypeSaxos { get; set; } = new List<DexTradeTypeSaxo>();

    public virtual ICollection<DexTradeTypeSparnord> DexTradeTypeSparnords { get; set; } = new List<DexTradeTypeSparnord>();

    public virtual ICollection<DexTradeTypeVp> DexTradeTypeVps { get; set; } = new List<DexTradeTypeVp>();
}
