using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.Jyske;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.Jyske;

public class DividendTransactionsProcessor(IExtractor<Dividend> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger, IInstrumentHelper instrumentHelper) :
    BaseTransactionFileProcessor<Dividend>(extractor, transformerFactory, loader, bank, logger)
{
    private readonly IExtractor<Dividend> _extractor = extractor;

    protected override List<Dividend> Extract()
    {
        var extracted = _extractor.Extract <Dividend>();
        return extracted.Select(e =>
        {
            e._isin = instrumentHelper.GetISINByFundCode(e.FONDSKODE);
            return e;
        }).Where(PreTransformationFilter).ToList();
    }

    protected override bool PreTransformationFilter(Dividend record)
    {
        // Ignore mortgage coupons
        var instrument = instrumentHelper.GetInstrumentByIsin(record.ISIN);
        var tradeTypeId = bank.GetTradeType(record.TradeType).TradeTypeId;
        return !(tradeTypeId == 7 && instrument.ClassificationLevel4Name == "Mortgage Non Pfandbriefe");
    }
}