using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.Extractors;
using Serilog;

using RILBACashTransaction = DataAccess.FileAccess.BankFileTypes.RILBA.CashTransaction;

namespace DataAccess.FileAccess.FileProcessors.RILBA;

public class CashTransactionsProcessor(IExtractor<RILBACashTransaction> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger) :
    BaseTransactionFileProcessor<RILBACashTransaction>(extractor, transformerFactory, loader, bank, logger)
{
    protected override bool PreTransformationFilter(RILBACashTransaction record)
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
            if (record.AccountType == "DIV" && record.PostText.StartsWith(reverseTradeText)) return false;
        }
        return allowedTradeTypes.Contains(record.AccountType);
    }
}