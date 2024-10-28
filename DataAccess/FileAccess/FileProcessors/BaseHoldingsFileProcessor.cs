using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Models;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes;
using DataAccess.FileAccess.Extractors;
using Serilog;
using Shared.Enums;

namespace DataAccess.FileAccess.FileProcessors;

public class BaseHoldingsFileProcessor<T>(
   IExtractor<T> extractor,
   ITransformerFactory transformerFactory,
   ILoader loader,
   IBank bank,
   ILogger logger
   )
   : IFileProcessor
   where T : BankHolding
{
   private readonly HoldingsTransformer _holdingsTransformer = transformerFactory.CreateHoldingsTransformer(bank);

   private List<DexBankHoldingsCash> TransformToCashHolding(List<T> extracted)
   {
      var cashHoldings = extracted.Select(p =>
      {
         DexBankHoldingsCash? cashHolding = null;
         try
         {
            cashHolding = _holdingsTransformer.CreateCashHolding(p);
         }
         catch (Exception e)
         {
            logger.Error(e, e.Message);
         }

         return cashHolding;
      }).Where(p => p != null).ToList();

      return cashHoldings!;
   }

    private List<DexBankHoldingsInstrument> TransformToInstrumentHolding(List<T> extracted)
    {
        var instrumentHoldings = extracted.Select(p =>
        {
            DexBankHoldingsInstrument? instrumentHolding = null;
            try
            {
                instrumentHolding = _holdingsTransformer.CreateInstrumentHolding(p);
            }
            catch (Exception e)
            {
                logger.Error(e, e.Message);
            }

            return instrumentHolding;
        }).Where(p => p != null).ToList();

        // In case the holdings are split in the file, we group
        return instrumentHoldings.GroupBy(x => (x.AccountId, x.InstrumentId)).Select(g => new DexBankHoldingsInstrument
        {
            AccountId = g.First()!.AccountId,
            InstrumentId = g.First()!.InstrumentId,
            Currency = g.First()!.Currency,
            HoldingDate = g.First()!.HoldingDate,
            Quantity = g.Sum(x => x.Quantity)
        }).ToList();
    }

   protected bool PreTransformationFilter(T record)
   {
      return true;
   }

   protected virtual List<T> Extract()
   {
      return extractor.Extract<T>().Where(PreTransformationFilter).ToList();
   }

   public void Process()
   {
      var extracted = Extract().Where(PreTransformationFilter).ToList();   
      
      // Split
      var extractedCashHoldings = extracted.Where(e => e.HoldingType == HoldingType.Cash).ToList();
      var extractedInstrumentHoldings = extracted.Where(e => e.HoldingType == HoldingType.Instrument).ToList();
      
      var transformedCashHoldings = TransformToCashHolding(extractedCashHoldings);
      var transformedInstHoldings = TransformToInstrumentHolding(extractedInstrumentHoldings);
      
      // Load
      loader.Load(transformedCashHoldings);
      loader.Load(transformedInstHoldings);
   }
}  