using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.EFG;
using DataAccess.FileAccess.BankFileTypes.Nordnet;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors.EFG;
//
// public class SecurityTransactionsProcessor(IExtractor<SecurityTransaction> extractor, ITransformerFactory transformerFactory, ILoader loader, IBank bank, ILogger logger) :
//     BaseTransactionFileProcessor<SecurityTransaction>(extractor, transformerFactory, loader, bank, logger)
// {
//     protected override List<SecurityTransaction> Extract()
//     {
//         return extractor.Extract<TransactionsResult>((result) => result.Transactions).Where(PreTransformationFilter).ToList();
//     }
// }