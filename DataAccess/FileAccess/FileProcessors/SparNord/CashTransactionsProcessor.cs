using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.SparNord;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.SparNord;

public class CashTransactionsProcessor(IExtractor<CashTransaction> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger) :
    BaseTransactionFileProcessor<CashTransaction>(extractor, transformerFactory, loader, bank, logger)
{
    protected override bool PreTransformationFilter(CashTransaction record)
    {
        return record.TradeType != Consts.Ignore;
    }
}