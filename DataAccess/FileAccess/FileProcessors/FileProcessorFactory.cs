using System.Globalization;
using System.Text;
using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.BIL;
using DataAccess.FileAccess.BankFileTypes.Jyske;
using DataAccess.FileAccess.BankFileTypes.Saxo;
using DataAccess.FileAccess.Extractors;
using DataAccess.FileAccess.FileProcessors.EFG;
using DataAccess.FileAccess.FileProcessors.Jyske;
using DataAccess.FileAccess.FileProcessors.Nordnet;
using DataAccess.FileAccess.FileProcessors.Saxo;
using Serilog;
using Shared.Enums;
using JyskeCashTransaction = DataAccess.FileAccess.BankFileTypes.Jyske.CashTransaction;
using RILBADividend = DataAccess.FileAccess.BankFileTypes.RILBA.Dividend;
using RILBACashHolding = DataAccess.FileAccess.BankFileTypes.RILBA.CashHolding;
using SaxoCashHoldings = DataAccess.FileAccess.BankFileTypes.Saxo.CashHoldings;
using SparNordCashTransactionsProcessor = DataAccess.FileAccess.FileProcessors.SparNord.CashTransactionsProcessor;
using JyskeCashTransactionsProcessor = DataAccess.FileAccess.FileProcessors.Jyske.CashTransactionsProcessor;
using Transaction = DataAccess.FileAccess.BankFileTypes.Nordnet.Transaction;
using JyskeTransaction = DataAccess.FileAccess.BankFileTypes.Jyske.Transaction;
using TransactionsProcessor = DataAccess.FileAccess.FileProcessors.RILBA.TransactionsProcessor;
using DataAccess.FileAccess.FileProcessors.RILBA;
using InstrumentHoldingsFileProcessor = DataAccess.FileAccess.FileProcessors.Nordnet.InstrumentHoldingsFileProcessor;

namespace DataAccess.FileAccess.FileProcessors;

public class FileProcessorFactory(ILogger logger, IBankFactory bankFactory, ITransformerFactory transformerFactory, ILoader loader, IInstrumentHelper instrumentHelper, IAccountHelper accountHelper) : IFileProcessorFactory
{
    public IFileProcessor CreateFileProcessor(string filePath, Bank bankEnum)
    {
        var fileName = Path.GetFileName(filePath);
        var bank = bankFactory.CreateBank(bankEnum);
        switch (bankEnum)
        {
            case Bank.Saxo:
            {
                var configuration = new ExtractorConfiguration();
                if (IsSaxoShareTradesExecuted(fileName))
                    return new BaseTransactionFileProcessor<ShareTradesExecuted>(
                        new CsvExtractor<ShareTradesExecuted>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );

                if (IsSaxoDividend(fileName))
                    return new BaseTransactionFileProcessor<ShareDividend>(
                        new CsvExtractor<ShareDividend>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );

                if (IsSaxoCash(fileName))
                    return new BookkeepingCashProcessor(
                        new CsvExtractor<BookkeepingCash>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                
                if (IsSaxoBondsCoupons(fileName))
                    return new BondsCouponsProcessor(
                        new CsvExtractor<BondsCoupons>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                
                if (IsSaxoMutualFundsTradesExecuted(fileName))
                    return new BaseTransactionFileProcessor<MutualFundTradesExecuted>(
                        new CsvExtractor<MutualFundTradesExecuted>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                
                if (IsSaxoBondsTradesExecuted(fileName))
                    return new BondsTradesExecutedProcessor(
                        new CsvExtractor<BondsTradesExecuted>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                
                if (IsSaxoCashHoldings(fileName))
                    return new BaseHoldingsFileProcessor<SaxoCashHoldings>(
                        new CsvExtractor<SaxoCashHoldings>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                
                if (IsSaxoShareOpenPositions(fileName))
                    return new BaseHoldingsFileProcessor<ShareOpenPosition>(
                        new CsvExtractor<ShareOpenPosition>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger

                    );
                
                if (IsSaxoBondsOpenPositions(fileName))
                    return new BaseHoldingsFileProcessor<BondsOpenPosition>(
                        new CsvExtractor<BondsOpenPosition>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                
                if (IsSaxoMutualFundsOpenPositions(fileName))
                    return new BaseHoldingsFileProcessor<MutualFundsOpenPosition>(
                        new CsvExtractor<MutualFundsOpenPosition>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                
                break;
            }
            
            case Bank.Nordnet:
            {
                if (IsNordnetTransactions(fileName))
                    return new Nordnet.TransactionsProcessor(new XmlExtractor<Transaction>(filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger);

                if (IsNordnetCashHoldings(fileName))
                    return new CashHoldingsFileProcessor(new XmlExtractor<Portfolio>(filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger);

                if (IsNordnetInstrumentHoldings(fileName))
                    return new InstrumentHoldingsFileProcessor(
                        new XmlExtractor<BankFileTypes.Nordnet.InstrumentHolding>(filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger);
                break;  
            }
            
            case Bank.EFG:
            {
                var configuration = new ExtractorConfiguration
                {
                    Delimiter = ",",
                    // CultureInfo = CultureInfo.CurrentCulture,
                    Encoding = Encoding.GetEncoding("ISO-8859-1"),
                    ShouldSkip = args => args.Row.GetField(0) != null &&
                                         args.Row.GetField(0)!.StartsWith("START-OF") ||
                                         args.Row.GetField(0)!.StartsWith("END-OF") ||
                                         args.Row.GetField(0)!.StartsWith("ExtractionTime") ||
                                         args.Row.GetField(0)!.StartsWith("IdType") ||
                                         args.Row.GetField(0)!.StartsWith("Id=") ||
                                         args.Row.GetField(0)!.StartsWith("Table") ||
                                         args.Row.GetField(0)!.StartsWith("RowCount") ||
                                         args.Row.GetField(0)!.StartsWith("FromDate") ||
                                         args.Row.GetField(0)!.StartsWith("ToDate")
                };

                if (IsEFGHoldings(fileName))
                {
                    return new HoldingsFileProcessor(
                        new EFGCsvExtractor<BankFileTypes.EFG.Holdings>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger,
                        accountHelper
                    );
                }

                if (IsEFGSecurityTransactions(fileName))
                {
                    return new BaseTransactionFileProcessor<BankFileTypes.EFG.SecurityTransaction>(
                        new EFGCsvExtractor<BankFileTypes.EFG.SecurityTransaction>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                }
                
                if (IsEFGAccountOther(fileName))
                {
                    return new AccountOthersProcessor(
                        new EFGCsvExtractor<BankFileTypes.EFG.AccountOther>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                }
                
                if (IsEFGSecurityEvent(fileName))
                {
                    return new BaseTransactionFileProcessor<BankFileTypes.EFG.SecurityEvent>(
                        new EFGCsvExtractor<BankFileTypes.EFG.SecurityEvent>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                }
                
                if (IsEFGLine(fileName))
                {
                    return new BaseTransactionFileProcessor<BankFileTypes.EFG.Line>(
                        new EFGCsvExtractor<BankFileTypes.EFG.Line>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                }
                
                if (IsEFGInterest(fileName))
                {
                    return new BaseTransactionFileProcessor<BankFileTypes.EFG.Interest>(
                        new EFGCsvExtractor<BankFileTypes.EFG.Interest>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                }

                break;  
            }
            
            case Bank.Jyske:
            {
                var configuration = new ExtractorConfiguration
                {
                    Delimiter = ";",
                    CultureInfo = CultureInfo.CurrentCulture,
                    Encoding = Encoding.GetEncoding("ISO-8859-1"),
                };

                if (IsJyskeOrRILBADividends(fileName))
                    return new DividendTransactionsProcessor(
                        new CsvExtractor<Dividend>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger,
                        instrumentHelper
                    );

                if (IsJyskeOrRILBATransactions(fileName))
                    return new Jyske.TransactionsProcessor(
                        new CsvExtractor<JyskeTransaction>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger,
                        instrumentHelper
                    );

                if (IsJyskeOrRILBACashTransaction(fileName))
                    return new JyskeCashTransactionsProcessor(
                        new CsvExtractor<JyskeCashTransaction>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger);

                if (IsJyskeOrRILBACashHolding(fileName))
                    return new BaseHoldingsFileProcessor<CashHolding>(
                        new CsvExtractor<CashHolding>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger);

                if (IsJyskeOrRILBAInstrumentHolding(fileName))
                    return new Jyske.InstrumentHoldingsFileProcessor(
                        new CsvExtractor<InstrumentHolding>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger);
                
                break;  
            }
            
            case Bank.RILBA:
            {
                var configuration = new ExtractorConfiguration
                {
                    Delimiter = ";",
                    CultureInfo = CultureInfo.CurrentCulture,
                    Encoding = Encoding.GetEncoding("ISO-8859-1"),
                };

                if (IsJyskeOrRILBATransactions(fileName))
                    return new TransactionsProcessor(
                        new CsvExtractor<BankFileTypes.RILBA.Transaction>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger,
                        instrumentHelper
                    );

                if(IsJyskeOrRILBADividends(fileName))
                    return new DividendsProcessor(
                        new CsvExtractor<RILBADividend>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger,
                        instrumentHelper
                    );
                
                // TODO Does not work currently, lacking trade types
                // if(IsJyskeOrRILBACashTransaction(fileName))
                //     return new RILBACashTransactionsProcessor(new CsvExtractor<RILBACashTransaction>(configuration, filePath), logger);

                if (IsJyskeOrRILBACashHolding(fileName))
                    return new BaseHoldingsFileProcessor<RILBACashHolding>(
                        new CsvExtractor<RILBACashHolding>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger);

                if (IsJyskeOrRILBAInstrumentHolding(fileName))
                    return new BaseHoldingsFileProcessor<BankFileTypes.RILBA.InstrumentHolding>(
                        new CsvExtractor<BankFileTypes.RILBA.InstrumentHolding>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger);
                
                break;  
            }

            case Bank.Bil:
            {
                var configuration = new ExtractorConfiguration
                {
                    Delimiter = ";",
                    CultureInfo = CultureInfo.CurrentCulture
                };
                
                if(IsBilTransactions(fileName))
                    return new BaseTransactionFileProcessor<BankFileTypes.BIL.Transaction>(
                        new CsvExtractor<BankFileTypes.BIL.Transaction>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                
                if(IsBilHoldings(fileName))
                    return new BIL.HoldingsFileProcessor(
                        new CsvExtractor<Holdings>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger,
                        accountHelper
                    );
                break;
            }

            case Bank.SparNord:
            {
                var configuration = new ExtractorConfiguration
                {
                    Delimiter = ";",
                    HasHeaderRecord = false,
                    CultureInfo = CultureInfo.InvariantCulture,
                    ShouldSkip = (args) => 
                        args.Row.GetField(0) != null && 
                        args.Row.GetField(0)!.StartsWith("TAIL") || 
                        args.Row.GetField(0)!.StartsWith("HEAD")
                };
                
                if(IsSparNordCash(fileName))
                    return new SparNordCashTransactionsProcessor(
                        new CsvExtractor<BankFileTypes.SparNord.CashTransaction>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger);
                
                if(IsSparNordCashHoldings(fileName))
                    return new BaseHoldingsFileProcessor<BankFileTypes.SparNord.CashHolding>(
                        new CsvExtractor<BankFileTypes.SparNord.CashHolding>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger
                    );
                
                if(IsSparNordInstrumentHoldings(fileName))
                    return new SparNord.InstrumentHoldingsFileProcessor(
                        new CsvExtractor<BankFileTypes.SparNord.InstrumentHolding>(configuration, filePath),
                        transformerFactory,
                        loader,
                        bank,
                        logger,
                        accountHelper
                    );
                break;
            }
        }

        logger.Error(Consts.NoProcessor(fileName));
        throw new Exception(Consts.NoProcessor(fileName));
    }
    
    private bool IsSaxoShareTradesExecuted(string fileName)
    {
        return fileName.StartsWith("ShareTradesExecuted");
    }
    
    private bool IsSaxoMutualFundsTradesExecuted(string fileName)
    {
        return fileName.StartsWith("MutualFundsTradesExecuted");
    }
    
    private bool IsSaxoBondsTradesExecuted(string fileName)
    {
        return fileName.StartsWith("BondsTradesExecuted");
    }
    
    private bool IsSaxoBondsCoupons(string fileName)
    {
        return fileName.StartsWith("BondsCoupons");
    }
    
    private bool IsSaxoDividend(string fileName)
    {
        return fileName.StartsWith("ShareDividend");
    }
    
    private bool IsSaxoCash(string fileName)
    {
        return fileName.StartsWith("BookkeepingCash");
    }
    
    private bool IsSaxoCashHoldings(string fileName)
    {
        return fileName.StartsWith("AccountStatus");
    }
    
    private bool IsSaxoShareOpenPositions(string fileName)
    {
        return fileName.StartsWith("ShareOpenPositions");
    }
    
    private bool IsSaxoBondsOpenPositions(string fileName)
    {
        return fileName.StartsWith("BondsOpenPositions");
    }
    
    private bool IsSaxoMutualFundsOpenPositions(string fileName)
    {
        return fileName.StartsWith("MutualFundsOpenPositions");
    }
    
    private bool IsNordnetTransactions(string fileName)
    {
        return fileName.StartsWith("transactions");
    }
    
    private bool IsNordnetCashHoldings(string fileName)
    {
        return fileName.StartsWith("cash");
    }
    
    private bool IsNordnetInstrumentHoldings(string fileName)
    {
        return fileName.StartsWith("positions");
    }
    
    private bool IsEFGHoldings(string fileName)
    {
        return fileName.EndsWith("ECDS_POS.csv");
    }
    
    private bool IsEFGSecurityTransactions(string fileName)
    {
        return fileName.EndsWith("ECDS_SCTR.csv");
    }
    
    private bool IsEFGAccountOther(string fileName)
    {
        return fileName.EndsWith("ACCT_OTHER.csv");
    }
    
    private bool IsEFGSecurityEvent(string fileName)
    {
        return fileName.EndsWith("ECDS_SCEV.csv");
    }
    
    private bool IsEFGLine(string fileName)
    {
        return fileName.EndsWith("ACCT_LD.csv");
    }
    
    private bool IsEFGInterest(string fileName)
    {
        return fileName.EndsWith("ACCT_INTR.csv");
    }

    
    private bool IsJyskeOrRILBADividends(string fileName)
    {
        return fileName.Contains("UBYT-MULTI");
    }

    private bool IsJyskeOrRILBATransactions(string fileName)
    {
        return fileName.Contains("HNDL-MULTI");
    }

    private bool IsJyskeOrRILBACashTransaction(string fileName)
    {
        return fileName.Contains("POST-MULTIUDTOG");
    }
    
    private bool IsJyskeOrRILBACashHolding(string fileName)
    {
        return fileName.Contains("SALDO-MULTIUDTOG");
    }
    
    private bool IsJyskeOrRILBAInstrumentHolding(string fileName)
    {
        return fileName.Contains("BEHL-MULTI");
    }
    
    private bool IsSparNordCash(string fileName)
    {
        return fileName.Contains("kntbv");
    }
    
    private bool IsSparNordCashHoldings(string fileName)
    {
        return fileName.Contains("pfknt");
    }
    
    private bool IsSparNordInstrumentHoldings(string fileName)
    {
        return fileName.Contains("pfbeh");
    }
    
    private bool IsBilTransactions(string fileName)
    {
        return fileName.StartsWith("AAAROP") && fileName.EndsWith(".csv");
    }
        
    private bool IsBilHoldings(string fileName)
    {
        return fileName.StartsWith("AAARPC") && fileName.EndsWith(".csv");
    }
}