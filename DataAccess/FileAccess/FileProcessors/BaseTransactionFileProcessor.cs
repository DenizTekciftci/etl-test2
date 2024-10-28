using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Enums;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Models;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes;
using DataAccess.FileAccess.Extractors;
using Serilog;

namespace DataAccess.FileAccess.FileProcessors;

public class BaseTransactionFileProcessor<T>(
   IExtractor<T> extractor,
   ITransformerFactory
      transformerFactory,
   ILoader loader,
   IBank bank,
   ILogger logger)
   : IFileProcessor
   where T : BankTransaction
{
   private readonly TransactionTransformer _transactionTransformer = transformerFactory.CreateTransactionTransformer(bank);
   private readonly CostTransformer _costTransformer = transformerFactory.CreateCostTransfomer(bank);

   private List<(DexSecurityTransaction, List<DexCost>)> TransformToSecurityTransactions(List<T> extracted)
   {
      var tradesAndCosts = extracted.Select(p =>
      {
         DexSecurityTransaction? transaction = null;
         List<DexCost> costs = [];
         try
         {
            transaction = _transactionTransformer.CreateSecurityTransaction(p);
            costs = _costTransformer.CreateAllCosts(p);
         }
         catch (Exception e)
         {
            TransformToSecurityAndLoadToStaging(p);
            logger.Error(e, e.Message);
         }

         return (transaction, costs);
      }).Where(p => p.transaction != null).ToList();

      return tradesAndCosts!;
   }

   private List<(DexDividendTransaction, List<DexCost>)> TransformToDividendsTransaction(List<T> extracted)
   {
      var tradesAndCosts = extracted.Select(p =>
      {
         DexDividendTransaction? transaction = null;
         List<DexCost> costs = [];
         try
         {
            transaction = _transactionTransformer.CreateDividendTransaction(p);
            costs = _costTransformer.CreateAllCosts(p);
         }
         catch (Exception e)
         {
            TransformToDividendAndLoadToStaging(p);
            logger.Error(e, e.Message);
         } 
            
         return (transaction, costs);
      }).Where(p => p.transaction != null).ToList();

      return tradesAndCosts!;
   }

   private List<(DexCashTransaction, List<DexCost>)> TransformToCashTransaction(List<T> extracted)
   {
      var tradesAndCosts = extracted.Select(p =>
      {
         DexCashTransaction? transaction = null;
         List<DexCost> costs = [];
         try
         {
            transaction = _transactionTransformer.CreateCashTransaction(p);
            costs = _costTransformer.CreateAllCosts(p);
         }
         catch (Exception e)
         {
            TransformToCashAndLoadToStaging(p);
            logger.Error(e, e.Message);
         } 
            
         return (transaction, costs);
      }).Where(p => p.transaction != null).ToList();

      return tradesAndCosts!;
   }

   private List<(DexBondCoupon, List<DexCost>)> TransformToBoundCoupon(List<T> extracted)
   {
      var tradesAndCosts = extracted.Select(p =>
      {
         DexBondCoupon? transaction = null;
         List<DexCost> costs = [];
         try
         {
            transaction = _transactionTransformer.CreateBondCoupon(p);
            costs = _costTransformer.CreateAllCosts(p);
         }
         catch (Exception e)
         {
            TransformToBondCouponAndLoadToStaging(p);
            logger.Error(e, e.Message);
         } 
            
         return (transaction, costs);
      }).Where(p => p.transaction != null).ToList();

      return tradesAndCosts!;
   }

   private List<DexCost> TransformToCosts(List<T> extracted)
   {
      var tradesAndCosts = extracted.Select(p =>
      {
         DexCost? costs = null;
         try
         {
            costs = _costTransformer.CreateCost(p, p.TradeType, p.Amount);
         }
         catch (Exception e)
         {
            logger.Error(e, e.Message);
         }
            
         return costs;
      }).Where(t => t != null).ToList();

      return tradesAndCosts!;
   }
   
   private void TransformToDividendAndLoadToStaging(T extracted)
   {
      try
      {
         var stagingTransaction = _transactionTransformer.CreateStagingDividendTransaction(extracted);
         var stagingCosts = _costTransformer.CreateAllStagingCosts(extracted, Consts.DexDividendTransactions);
         loader.Load(stagingTransaction, stagingCosts);
      }
      catch (Exception e)
      {
         logger.Error(e, e.Message);
      }
   }
   
   private void TransformToCashAndLoadToStaging(T extracted)
   {
      try
      {
         var stagingTransaction = _transactionTransformer.CreateStagingCashTransaction(extracted);
         var stagingCosts = _costTransformer.CreateAllStagingCosts(extracted, Consts.DexCashTransactions);
         loader.Load(stagingTransaction, stagingCosts);
      }
      catch (Exception e)
      {
         logger.Error(e, e.Message);
      }
   }
   
   private void TransformToBondCouponAndLoadToStaging(T extracted)
   {
      try
      {
         var stagingTransaction = _transactionTransformer.CreateStagingBondCouponTransaction(extracted);
         var stagingCosts = _costTransformer.CreateAllStagingCosts(extracted, Consts.DexBondCoupons);
         loader.Load(stagingTransaction, stagingCosts);
      }
      catch (Exception e)
      {
         logger.Error(e, e.Message);
      }
   }
   
   private void TransformToSecurityAndLoadToStaging(T extracted)
   {
      try
      {
         var stagingTransaction = _transactionTransformer.CreateStagingSecurityTransaction(extracted);
         var stagingCosts = _costTransformer.CreateAllStagingCosts(extracted, Consts.DexSecurityTransactions);
         loader.Load(stagingTransaction, stagingCosts);
      }
      catch (Exception e)
      {
         logger.Error(e, e.Message);
      }
   }
   
   protected virtual bool PreTransformationFilter(T record)
   {
      return true;
   }
   protected virtual List<T> Extract()
   {
      return extractor.Extract<T>().Where(PreTransformationFilter).ToList();
   }

   public virtual void Process()
   {
      var extracted = Extract();
      
      // Split
      var extractedSecurityTransactions = extracted.Where(e => bank.GetTransactionTableFromTradeType(e.TradeType) == TransactionTables.SecurityTransactions).ToList();
      var extractedDividendTransactions = extracted.Where(e => bank.GetTransactionTableFromTradeType(e.TradeType) == TransactionTables.DividendTransactions).ToList();
      var extractedCashTransactions = extracted.Where(e => bank.GetTransactionTableFromTradeType(e.TradeType) == TransactionTables.CashTransactions).ToList();
      var extractedBondCoupons = extracted.Where(e => bank.GetTransactionTableFromTradeType(e.TradeType) == TransactionTables.BondCoupons).ToList();
      var extractedCosts = extracted.Where(e => bank.GetTransactionTableFromTradeType(e.TradeType) == TransactionTables.Costs).ToList();
      
      // Transform
      var transformedSecurityTransactions = TransformToSecurityTransactions(extractedSecurityTransactions);
      var transformedDividendTransactions = TransformToDividendsTransaction(extractedDividendTransactions);
      var transformedCashTransactions = TransformToCashTransaction(extractedCashTransactions);
      var transformedBondCoupons = TransformToBoundCoupon(extractedBondCoupons);
      var transformedCosts = TransformToCosts(extractedCosts);
      
      // Load
      loader.Load(transformedSecurityTransactions);
      loader.Load(transformedDividendTransactions);
      loader.Load(transformedCashTransactions);
      loader.Load(transformedBondCoupons);
      loader.Load(transformedCosts);
   }
}  