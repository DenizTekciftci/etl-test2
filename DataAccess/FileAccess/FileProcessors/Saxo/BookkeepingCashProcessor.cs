using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.Saxo;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.Saxo;

public class BookkeepingCashProcessor(IExtractor<BookkeepingCash> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger) :
    BaseTransactionFileProcessor<BookkeepingCash>(extractor, transformerFactory, loader, bank, logger)
{
    protected override List<BookkeepingCash> Extract()
    {
        var extracted = extractor.Extract<BookkeepingCash>().Where(PreTransformationFilter);
        return extracted.Select(e =>
        {
            e.TradeTypeName = e.GetTradeTypeName(bank);
            return e;
        }).ToList();
    }
}