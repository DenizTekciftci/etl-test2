using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.Jyske;
using DataAccess.FileAccess.Extractors;
using Serilog;
using Shared.Enums;

namespace DataAccess.FileAccess.FileProcessors.Jyske;

// Unused
public class TransferTransactionsProcessor(IExtractor<Transfers> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger, IInstrumentHelper instrumentHelper) :
    BaseTransactionFileProcessor<Transfers>(extractor, transformerFactory, loader, bank, logger)
{
    private readonly IExtractor<Transfers> _extractor = extractor;

    protected override List<Transfers> Extract()
    {
        var extracted = _extractor.Extract <Dividend>();
        return extracted.Select(e =>
        {
            e.Isin = instrumentHelper.GetISINByFundCode(e.FONDSKODE);
            return e;
        }).ToList();
    }
}