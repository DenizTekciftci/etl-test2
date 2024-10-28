using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.Saxo;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.Saxo;

public class BondsTradesExecutedProcessor(IExtractor<BondsTradesExecuted> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger) :
    BaseTransactionFileProcessor<BondsTradesExecuted>(extractor, transformerFactory, loader, bank, logger)
{
    protected override bool PreTransformationFilter(BondsTradesExecuted bondsTradesExecuted)
    {
        // Remove bond drawings
        return bondsTradesExecuted.OriginatingTool != "Bond Drawing";
    }
}