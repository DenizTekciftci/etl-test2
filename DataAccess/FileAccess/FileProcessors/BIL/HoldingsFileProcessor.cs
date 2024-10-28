using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.BIL;
using DataAccess.FileAccess.Extractors;
using Serilog;
using Shared.Enums;

namespace DataAccess.FileAccess.FileProcessors.BIL;

public class HoldingsFileProcessor(IExtractor<Holdings> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger, IAccountHelper accountHelper) :
    BaseHoldingsFileProcessor<Holdings>(extractor, transformerFactory, loader, bank, logger)
{
    private readonly IExtractor<Holdings> _extractor = extractor;

    protected override List<Holdings> Extract()
    {
        var extracted = _extractor.Extract<Holdings>().ToList();
        return extracted.Select(e =>
        {
            e.account = e.HoldingType == HoldingType.Cash
                ? e.instrument
                : accountHelper.GetAccountNameFromDepotNameAndCurrency(e.Racine, e.Currency);
            return e;
        }).ToList();

    }
}