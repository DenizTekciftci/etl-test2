using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Models;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.Jyske;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.Jyske;

public class InstrumentHoldingsFileProcessor(IExtractor<InstrumentHolding> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger) :
    BaseHoldingsFileProcessor<InstrumentHolding>(extractor, transformerFactory, loader, bank, logger)
{
    protected override List<InstrumentHolding> Extract()
    {
        var extracted = extractor.Extract<InstrumentHolding>().Where(PreTransformationFilter).ToList();
        
        // Load new fund codes
        var allFundCodes = bank.GetFundCodes().Select(f => f.FundCode);
        var newFundCodes = extracted.Select(e => new DexFundCode
        {
            FundCode = e.FONDSKODE,
            Isin = e.ISIN,
        }).Where(f => !allFundCodes.Contains(f.FundCode)).ToList();
        loader.Load(newFundCodes);
        
        return extracted;
    }
}