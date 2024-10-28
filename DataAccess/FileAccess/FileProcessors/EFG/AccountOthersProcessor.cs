using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.EFG;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.EFG;

public class AccountOthersProcessor(IExtractor<AccountOther> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger) :
    BaseTransactionFileProcessor<AccountOther>(extractor, transformerFactory, loader, bank, logger)
{

    protected override List<AccountOther> Extract()
    {
        var extracted = extractor.Extract<AccountOther>().Where(PreTransformationFilter);
        return extracted.Select(e =>
        {
            e.TradeTypeName = e.GetTradeTypeName(bank);
            return e;
        }).ToList();
    }
}