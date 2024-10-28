using DataAccess.DatabaseAccess.Infrastructure;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexCost : ITransactionType
{
    int ITransactionType.PpTransaction
    {
        get => PpTransaction;
        set => PpTransaction = (sbyte)value;
    }
    
    int ITransactionType.CashImpact
    {
        get => CashImpact;
        set => CashImpact = (sbyte)value;
    }
}