using DataAccess.DatabaseAccess.Infrastructure;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTradeTypeRilba : BaseTradeType, ITradeType
{
    int ITradeType.TradeTypeId => TradeTypeId;
    int ITradeType.CashImpact => CashImpact;
    int ITradeType.NominalImpact => NominalImpact;
    int? ITradeType.QuantityFactor => QuantityFactor;
    int ITradeType.AmountFactor => AmountFactor;
    int? ITradeType.CostsFactor => 1;
}