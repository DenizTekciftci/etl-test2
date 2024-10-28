namespace DataAccess.DatabaseAccess.Infrastructure;

public interface ITradeType
{
    public int TradeTypeId { get;  }
    public string BankTypeName { get; }
    public int AmountFactor { get; }
    public int NominalImpact { get; }
    public int CashImpact { get; }
    public int? CostsFactor { get; }
    public int? QuantityFactor { get; }
}

public abstract class BaseTradeType
{
}