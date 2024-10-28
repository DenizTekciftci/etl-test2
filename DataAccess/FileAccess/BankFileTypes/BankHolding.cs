using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Models;
using Shared.Enums;

namespace DataAccess.FileAccess.BankFileTypes;

public abstract class BankHolding
{
    public abstract DateTime HoldingDate { get; }
    public abstract string ISIN { get; }
    public abstract decimal? Amount { get; }
    public abstract decimal? Quantity { get; }
    public abstract string Currency { get; }
    public abstract string AccountName { get; }
    public abstract HoldingType HoldingType { get; }
}