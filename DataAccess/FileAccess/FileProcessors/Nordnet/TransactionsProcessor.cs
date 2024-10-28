using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.Nordnet;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.Nordnet;

public class TransactionsProcessor(IExtractor<Transaction> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger) :
    BaseTransactionFileProcessor<Transaction>(extractor, transformerFactory, loader, bank, logger)
{
    protected override List<Transaction> Extract()
    {
        return extractor.Extract<TransactionsResult>((result) => result.Transactions).Where(PreTransformationFilter).ToList();
    }
}