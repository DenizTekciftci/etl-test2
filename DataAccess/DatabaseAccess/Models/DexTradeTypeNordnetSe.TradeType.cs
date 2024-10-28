using DataAccess.DatabaseAccess.Infrastructure;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexTradeTypeNordnetSe : BaseTradeType, ITradeType
{
    int ITradeType.CashImpact => CashImpact;
    int ITradeType.NominalImpact => NominalImpact;
    int ITradeType.AmountFactor => AmountFactor;
    int? ITradeType.QuantityFactor => QuantityFactor;
    int? ITradeType.CostsFactor => 1;
}