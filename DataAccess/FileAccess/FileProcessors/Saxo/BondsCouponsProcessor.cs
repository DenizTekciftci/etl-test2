using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.Saxo;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.Saxo;

public class BondsCouponsProcessor(IExtractor<BondsCoupons> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger) :
    BaseTransactionFileProcessor<BondsCoupons>(extractor, transformerFactory, loader, bank, logger)
{
    protected override bool PreTransformationFilter(BondsCoupons bondCoupon)
    {
        // Remove bond drawings
        var eomReturnDates = bank.GetEomReturnDates().OrderByDescending(e => e.ReturnDate).ToList();
        return !(bondCoupon.Currency == "DKK" && bondCoupon.TradeDate == eomReturnDates[^2].ReturnDate);
    }
}