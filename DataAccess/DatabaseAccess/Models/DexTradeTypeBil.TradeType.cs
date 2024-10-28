using DataAccess.DatabaseAccess.Infrastructure;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTradeTypeBil : BaseTradeType, ITradeType
{
    int ITradeType.CashImpact => CashImpact;
    int ITradeType.NominalImpact => NominalImpact;
    int ITradeType.AmountFactor => AmountFactor != null ? (int)AmountFactor : 1;
    int? ITradeType.QuantityFactor => (int?)QuantityFactor;
    int? ITradeType.CostsFactor => CostsFactor != null ? (int)CostsFactor : 1;
}