using DataAccess.FileAccess.BankFileTypes;

namespace Tests.Mock;

public class MockTransaction : BankTransaction
{
    public override DateTime TradeDate { get; }
    public override DateTime ValueDate { get; }
    public override string Currency { get; }
    public override double Price { get; }
    public override double Quantity { get; set; }
    public override double Amount { get; set; }
    public override string ISIN { get; }
    public override string TradeType { get; }
    public override string Account { get; }
    public override List<(string costType, double cost)> GetCosts()
    {
        return
        [
            ("TESTCOST1", 10.0),
            ("TESTCOST2", 20.0)
        ];
    }
}