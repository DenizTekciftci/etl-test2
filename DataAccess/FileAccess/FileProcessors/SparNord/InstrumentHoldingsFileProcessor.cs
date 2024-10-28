using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.SparNord;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.SparNord;

public class InstrumentHoldingsFileProcessor(IExtractor<InstrumentHolding> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger, IAccountHelper accountHelper) :
    BaseHoldingsFileProcessor<InstrumentHolding>(extractor, transformerFactory, loader, bank, logger)
{
    private readonly IExtractor<InstrumentHolding> _extractor = extractor;

    protected override List<InstrumentHolding> Extract()
    {
        var extracted = _extractor.Extract<InstrumentHolding>().Where(PreTransformationFilter);
        return extracted.Select(e =>
        {
            e.account = accountHelper.GetAccountNameFromDepotNameAndCurrency(e.Depot, e.Currency);
            return e;
        }).ToList();
    }   
}