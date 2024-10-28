using CsvHelper.Configuration.Attributes;

namespace DataAccess.FileAccess.BankFileTypes.RILBA;


public class Transaction : Jyske.Transaction
{
    public override List<(string costType, double cost)> GetCosts()
    {
        return
        [
            ("COMMISSIONS", Cost)
        ];
    }
}