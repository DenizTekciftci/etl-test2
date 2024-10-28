using DataAccess.DatabaseAccess.Banks;
using RILBABank = DataAccess.DatabaseAccess.Banks.RILBA;
namespace DataAccess.FileAccess.BankFileTypes.RILBA;

// Exact same format as Jyske
public class Dividend : Jyske.Dividend
{
    public override string TradeType => $"{RecType}{AfkastType}";
    //public override 
}