using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.Nordnet;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.Nordnet;

public class InstrumentHoldingsFileProcessor(IExtractor<InstrumentHolding> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger) :
    BaseHoldingsFileProcessor<InstrumentHolding>(extractor, transformerFactory, loader, bank, logger)
{
    private readonly IExtractor<InstrumentHolding> _extractor = extractor;

    protected override List<InstrumentHolding> Extract()
    {
        return _extractor.Extract<InstrumentHoldingsResult>((result) => result.InstrumentHoldings);
    }
}