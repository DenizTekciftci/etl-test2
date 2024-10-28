using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Enums;
using DataAccess.DatabaseAccess.Infrastructure;
using DataAccess.DatabaseAccess.Models;

namespace DataAccess.FileAccess.BankFileTypes;

public abstract class BankTransaction
{
    public abstract DateTime TradeDate { get; }
    public abstract DateTime ValueDate { get; }
    public abstract string Currency { get; }
    public abstract double Price { get; }
    public abstract double Quantity { get; set; }
    public abstract double Amount { get; set; }
    public abstract string ISIN { get; }
    public abstract string TradeType { get; }
    public abstract string Account { get; }
    public abstract List<(string costType, double cost)> GetCosts();
}