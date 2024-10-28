using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.Jyske;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.Jyske;

public class TransactionsProcessor(IExtractor<Transaction> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger, IInstrumentHelper instrumentHelper) :
    BaseTransactionFileProcessor<Transaction>(extractor, transformerFactory, loader, bank, logger)
{
    private readonly IExtractor<Transaction> _extractor = extractor;

    protected override List<Transaction> Extract()
    {
        var extracted = _extractor.Extract<Transaction>();
        return extracted.Select(e =>
        {
            e._isin = instrumentHelper.GetISINByFundCode(e.FONDSKODE);
            return e;
        }).ToList();
    }
}