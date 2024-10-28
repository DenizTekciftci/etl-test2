using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.Jyske;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.Jyske;

public class CashTransactionsProcessor(IExtractor<CashTransaction> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger) :
    BaseTransactionFileProcessor<CashTransaction>(extractor, transformerFactory, loader, bank, logger)
{

    protected override List<CashTransaction> Extract()
    {
        var extracted = extractor.Extract<CashTransaction>().Where(PreTransformationFilter);
        return extracted.Select(e =>
        {
            e.TradeTypeName = e.GetTradeTypeName(bank);
            return e;
        }).ToList();
    }
    protected override bool PreTransformationFilter(CashTransaction record)
    {
        List<string> allowedTradeTypes =
        [
            "FIK",
            "BKA",
            "CHI",
            "DIV",
            "GEB",
            "INT",
            "JNE",
            "PAY",
            "PBS",
            "RET",
            "RTE",
            "SLT",
            "UDS",
        ];
        
        // Cash transactions file includes reversed trades that are not netted with trades file
        // ignore these
        List<string> reverseTradeTexts =
        [
            "Tilbf",
            "Fonds",
        ];

        foreach (var reverseTradeText in reverseTradeTexts)
        {
            if (record.Type == "DIV" && record.PostTekst.StartsWith(reverseTradeText)) return false;
        }
        return allowedTradeTypes.Contains(record.Type);
    }
}