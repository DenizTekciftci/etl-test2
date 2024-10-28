using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.EFG;
using DataAccess.FileAccess.Extractors;
using Serilog;
using Shared.Enums;

namespace DataAccess.FileAccess.FileProcessors.EFG;

public class HoldingsFileProcessor(IExtractor<Holdings> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger, IAccountHelper accountHelper) :
    BaseHoldingsFileProcessor<Holdings>(extractor, transformerFactory, loader, bank, logger)
{
    private readonly IExtractor<Holdings> _extractor = extractor;

    protected override List<Holdings> Extract()
    {
        var extracted = _extractor.Extract<Holdings>().Where(PreTransformationFilter);
        return extracted.Select(e =>
        {
            e.account = e.HoldingType == HoldingType.Cash
                ? e.PosSecId
                : accountHelper.GetAccountNameFromDepotNameAndCurrency(e.CustId, e.Currency);
            return e;
        }).ToList();
    }
}