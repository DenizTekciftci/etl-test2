namespace DataAccess.DatabaseAccess.Infrastructure;

public interface ITransactionType
{
     public int TransactionId { get; }
     public DateTime InputDate { get; set; }
     public DateTime TradeDate { get; set; }
     public DateTime ValueDate { get; set; }
     public int AccountId { get; set; }
     public int TradeTypeId { get; set; }
     public double Amount { get; set; }
     public string Currency { get; set; }
     public int PpTransaction { get; set; }
     public int CashImpact { get; set; }
}