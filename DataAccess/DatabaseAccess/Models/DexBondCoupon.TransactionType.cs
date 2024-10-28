using DataAccess.DatabaseAccess.Infrastructure;

namespace DataAccess.DatabaseAccess.Models;

public partial class DexBondCoupon : ITransactionType
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

    double ITransactionType.Amount
    {
        get => _amount;
        set => _amount = value;
    }
    private double _amount;
}