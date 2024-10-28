using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.RILBA;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.RILBA;

public class DividendsProcessor(IExtractor<Dividend> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger, IInstrumentHelper instrumentHelper) :
    BaseTransactionFileProcessor<Dividend>(extractor, transformerFactory, loader, bank, logger)
{
    private readonly IExtractor<Dividend> _extractor = extractor;

    protected override List<Dividend> Extract()
    {
        var extracted = _extractor.Extract<Dividend>();
        return extracted.Select(e =>
        {
            e._isin = instrumentHelper.GetISINByFundCode(e.FONDSKODE);
            return e;
        }).ToList();
    }
}