using DataAccess.DatabaseAccess.Infrastructure;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTradeTypeSparnord : BaseTradeType, ITradeType
{
    int ITradeType.TradeTypeId => TradeTypeId;
    int ITradeType.CashImpact => CashImpact;
    int ITradeType.NominalImpact => NominalImpact;
    int? ITradeType.QuantityFactor => (int?)QuantityFactor;
    int ITradeType.AmountFactor => (int)AmountFactor;
    int? ITradeType.CostsFactor => 1;
}