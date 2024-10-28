using DataAccess.DatabaseAccess.Infrastructure;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTradeTypeEfg : BaseTradeType, ITradeType
{
    int ITradeType.TradeTypeId => TradeTypeId ?? 1;
    int ITradeType.CashImpact => CashImpact;
    int ITradeType.NominalImpact => NominalImpact;
    int? ITradeType.QuantityFactor => (int?)QuantityFactor;
    int ITradeType.AmountFactor => AmountFactor != null ? (int)AmountFactor : 1;
    int? ITradeType.CostsFactor => CostsFactor != null ? (int)CostsFactor : 1;
}