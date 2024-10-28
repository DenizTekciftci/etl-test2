using DataAccess.DatabaseAccess.Infrastructure;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTradeTypeSaxo : BaseTradeType, ITradeType
{
    int ITradeType.CashImpact => CashImpact;
    int ITradeType.NominalImpact => NominalImpact;
    int ITradeType.AmountFactor => AmountFactor;
    int? ITradeType.QuantityFactor => 1;
    int? ITradeType.CostsFactor => CostsFactor;
}