using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.Nordnet;

public class CashHoldingsFileProcessor(IExtractor<Portfolio> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger) :
    BaseHoldingsFileProcessor<Portfolio>(extractor, transformerFactory, loader, bank, logger)
{
    protected override List<Portfolio> Extract()
    {
        return extractor.Extract<CashHoldingsResult>((result) => result.Portfolio);
    }
}