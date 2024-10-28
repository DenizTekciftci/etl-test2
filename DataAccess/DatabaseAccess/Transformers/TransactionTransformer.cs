using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Infrastructure;
using DataAccess.DatabaseAccess.Models;
using DataAccess.FileAccess.BankFileTypes;

namespace DataAccess.DatabaseAccess.Transformers;

public class TransactionTransformer(IInstrumentHelper instrumentHelper, IAccountHelper accountHelper, IBank bank)
{
    public DexSecurityTransaction CreateSecurityTransaction(BankTransaction t)
    {
        var transaction = CreateBaseTransaction<DexSecurityTransaction>(t);
        transaction.InstrumentId = instrumentHelper.GetInstrumentIdByIsin(t.ISIN);
        transaction.Quantity = t.Quantity * (bank.GetTradeType(t.TradeType).QuantityFactor ?? 1);
        transaction.Price = t.Price;
        transaction.NominalImpact = 1;
        transaction.DuplicateCount = 0;
        transaction.Counterpart = (sbyte)bank.GetBankId();
        return transaction;
    }
    
    public DexDividendTransaction CreateDividendTransaction(BankTransaction t)
    {
        var transaction = CreateBaseTransaction<DexDividendTransaction>(t);
        transaction.InstrumentId = instrumentHelper.GetInstrumentIdByIsin(t.ISIN);
        transaction.Quantity = t.Quantity * (bank.GetTradeType(t.TradeType).QuantityFactor ?? 1);
        return transaction;
    }
    
    public DexCashTransaction CreateCashTransaction(BankTransaction t)
    {
        return CreateBaseTransaction<DexCashTransaction>(t);
    }
    
    public DexBondCoupon CreateBondCoupon(BankTransaction t)
    {
        var transaction = CreateBaseTransaction<DexBondCoupon>(t);
        transaction.InstrumentId = instrumentHelper.GetInstrumentIdByIsin(t.ISIN);
        return transaction;
    }

    private TransactionType CreateBaseTransaction<TransactionType>(BankTransaction t) where TransactionType : ITransactionType, new()
    {
        var transaction = new TransactionType();
        var tradeType = bank.GetTradeType(t.TradeType);
        transaction.AccountId = accountHelper.GetAccountId(t.Account, t.Currency, bank.GetBankId());
        transaction.TradeTypeId = tradeType.TradeTypeId;
        transaction.InputDate = DateTime.Today;
        transaction.TradeDate = t.TradeDate;
        transaction.ValueDate = t.ValueDate;
        transaction.Currency = t.Currency;
        transaction.Amount = t.Amount * tradeType.AmountFactor;
        transaction.PpTransaction = 1;
        transaction.CashImpact = 1;
        return transaction;
    } 
    
    public DexStagingSecurityTransaction CreateStagingSecurityTransaction(BankTransaction t)
    {
        var transaction = new DexStagingSecurityTransaction();
        try
        {
            transaction.InstrumentId = instrumentHelper.GetInstrumentIdByIsin(t.ISIN);
        }
        catch (Exception)
        {
            transaction.InstrumentId = null;
        }
        
        try
        {
            transaction.AccountId = accountHelper.GetAccountId(t.Account, t.Currency, bank.GetBankId());
        }
        catch (Exception)
        {
            transaction.AccountId = null;
        }
        
        try
        {
            var tradeType = bank.GetTradeType(t.TradeType);
            transaction.TradeTypeId = tradeType.TradeTypeId;
            transaction.Amount = t.Amount * tradeType.AmountFactor;
        }
        catch (Exception)
        {
            transaction.TradeTypeId = null;
            transaction.Amount = t.Amount;
        }
        
        transaction.Isin = t.ISIN;
        transaction.Account = t.Account;
        transaction.TradeTypeName = t.TradeType;
        transaction.InputDate = DateTime.Today;
        transaction.TradeDate = t.TradeDate;
        transaction.ValueDate = t.ValueDate;
        transaction.Currency = t.Currency;
        transaction.PpTransaction = 1;
        transaction.CashImpact = 1;
        transaction.Quantity = t.Quantity * (bank.GetTradeType(t.TradeType).QuantityFactor ?? 1);
        transaction.Price = t.Price;
        transaction.NominalImpact = 1;
        transaction.DuplicateCount = 0;
        return transaction;
    }
    
    public DexStagingDividendTransaction CreateStagingDividendTransaction(BankTransaction t)
    {
        var transaction = new DexStagingDividendTransaction();
        try
        {
            transaction.InstrumentId = instrumentHelper.GetInstrumentIdByIsin(t.ISIN);
        }
        catch (Exception)
        {
            transaction.InstrumentId = null;
        }
        
        try
        {
            transaction.AccountId = accountHelper.GetAccountId(t.Account, t.Currency, bank.GetBankId());
        }
        catch (Exception)
        {
            transaction.AccountId = null;
        }
        
        try
        {
            var tradeType = bank.GetTradeType(t.TradeType);
            transaction.TradeTypeId = tradeType.TradeTypeId;
            transaction.Amount = t.Amount * tradeType.AmountFactor;
        }
        catch (Exception)
        {
            transaction.TradeTypeId = null;
            transaction.Amount = t.Amount;
        }
        
        transaction.Isin = t.ISIN;
        transaction.Account = t.Account;
        transaction.TradeTypeName = t.TradeType;
        transaction.InputDate = DateTime.Today;
        transaction.TradeDate = t.TradeDate;
        transaction.ValueDate = t.ValueDate;
        transaction.Currency = t.Currency;
        transaction.PpTransaction = 1;
        transaction.CashImpact = 1;
        transaction.Quantity = t.Quantity * (bank.GetTradeType(t.TradeType).QuantityFactor ?? 1);
        return transaction;
    }
    
    public DexStagingCashTransaction CreateStagingCashTransaction(BankTransaction t)
    {
        var transaction = new DexStagingCashTransaction();
        try
        {
            transaction.AccountId = accountHelper.GetAccountId(t.Account, t.Currency, bank.GetBankId());
        }
        catch (Exception)
        {
            transaction.AccountId = null;
        }
        
        try
        {
            var tradeType = bank.GetTradeType(t.TradeType);
            transaction.TradeTypeId = tradeType.TradeTypeId;
            transaction.Amount = t.Amount * tradeType.AmountFactor;
        }
        catch (Exception)
        {
            transaction.TradeTypeId = null;
            transaction.Amount = t.Amount;
        }

        transaction.Account = t.Account;
        transaction.TradeTypeName = t.TradeType;
        transaction.InputDate = DateTime.Today;
        transaction.TradeDate = t.TradeDate;
        transaction.ValueDate = t.ValueDate;
        transaction.Currency = t.Currency;
        transaction.PpTransaction = 1;
        transaction.CashImpact = 1;
        return transaction;
    }
    
    public DexStagingBondCoupon CreateStagingBondCouponTransaction(BankTransaction t)
    {
        var transaction = new DexStagingBondCoupon();
        try
        {
            transaction.AccountId = accountHelper.GetAccountId(t.Account, t.Currency, bank.GetBankId());
        }
        catch (Exception)
        {
            transaction.AccountId = null;
        }
        
        try
        {
            transaction.InstrumentId = instrumentHelper.GetInstrumentIdByIsin(t.ISIN);
        }
        catch (Exception)
        {
            transaction.InstrumentId = null;
        }
        
        try
        {
            var tradeType = bank.GetTradeType(t.TradeType);
            transaction.TradeTypeId = tradeType.TradeTypeId;
            transaction.Amount = t.Amount * tradeType.AmountFactor;
        }
        catch (Exception)
        {
            transaction.TradeTypeId = null;
            transaction.Amount = t.Amount;
        }
        
        transaction.Isin = t.ISIN;
        transaction.Account = t.Account;
        transaction.TradeTypeName = t.TradeType;
        transaction.InputDate = DateTime.Today;
        transaction.TradeDate = t.TradeDate;
        transaction.ValueDate = t.ValueDate;
        transaction.Currency = t.Currency;
        transaction.PpTransaction = 1;
        transaction.CashImpact = 1;
        return transaction;
    }
}