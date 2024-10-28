using DataAccess.DatabaseAccess.Enums;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Infrastructure;
using DataAccess.DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Banks;

public interface IBank
{
    public int GetBankCostId(string tradeTypeName);
    public int GetBankId();
    public List<ITradeType> GetTradeTypes();
    public List<EomReturnDate> GetEomReturnDates();
    public ITradeType GetTradeType(string tradeTypeName);
    public TransactionTables GetTransactionTableFromTradeType(string tradeType);
    public List<DexFundCode> GetFundCodes();
}
public abstract class Bank<T>(IDbContextFactory<PpcapitalContext> contextFactory) : IBank where T : BaseTradeType, ITradeType
{
    protected abstract string BankName { get; }
    protected abstract string TradeTypesTableName { get; }
    
    public int GetBankId()
    {   
        var context = contextFactory.CreateDbContext();
        return context.DexBanks.First(b => b.Bank == BankName).BankId;
    }

    private List<DexBankCost> GetBankCosts()
    {
        var context = contextFactory.CreateDbContext();
        var bankCosts = (
            from bc in context.DexBankCosts
            join b in context.DexBanks on bc.BankId equals b.BankId
            where b.Bank == BankName
            select bc); 
        
        return bankCosts.ToList();
    }

    public List<ITradeType> GetTradeTypes()
    {
        return GetTradeTypesForBank().ToList<ITradeType>();
    }

    public List<EomReturnDate> GetEomReturnDates()
    {
        return contextFactory.CreateDbContext().EomReturnDates.ToList();
    }

    public TransactionTables GetTransactionTableFromTradeType(string tradeType)
    {
        var context = contextFactory.CreateDbContext();
        var dexTableId = (
            from ttb in GetTradeTypeTable(context)
            join dtti in context.DexTradeTypeIds on ttb.TradeTypeId equals dtti.TradeTypeId 
            join dtt in context.DexTransactionTables on dtti.DexTableId equals dtt.DexTableId 
            where ttb.BankTypeName == tradeType
            select dtt.DexTableId).FirstOrDefault();

        if (dexTableId == 0)
        {
            MissingDataHelper.InsertNewTradeType(context, TradeTypesTableName, tradeType);
        }
        
        return (TransactionTables)dexTableId;
    }

    public List<DexFundCode> GetFundCodes()
    {
        var context = contextFactory.CreateDbContext();
        return context.DexFundCodes.ToList();
    }


    public virtual int GetBankCostId(string tradeTypeName)
    {
        var bankCost = GetBankCosts().FirstOrDefault(bc => bc.BankCostName == tradeTypeName);
        if (bankCost == null)
        {
            throw new Exception($"No bank cost: {tradeTypeName} for bank {BankName}");
        }
        
        return bankCost.BankCostId;
    }

    private List<T> GetTradeTypesForBank()
    {
        var context = contextFactory.CreateDbContext();
        return GetTradeTypeTable(context).ToList();
    }
    
    public virtual ITradeType GetTradeType(string tradeTypeName)
    {
        return GetTradeTypeForBank(tradeTypeName);
    }
    
    private ITradeType GetTradeTypeForBank(string tradeTypeName)
    {
        var context = contextFactory.CreateDbContext();
        var tradeType = GetTradeTypesForBank().FirstOrDefault(t => t.BankTypeName == tradeTypeName);

        if (tradeType != null) return tradeType;
        
        MissingDataHelper.InsertNewTradeType(context, TradeTypesTableName, tradeTypeName);
        throw new Exception(Consts.NoTradeTypeForBank(tradeTypeName, BankName));
    }
    
    public virtual int GetTradeTypeId(string tradeTypeName)
    {
        var context = contextFactory.CreateDbContext();
        var tradeTypes = GetTradeTypesForBank();
        var tradeTypeId = tradeTypes.FirstOrDefault(t => t.BankTypeName == tradeTypeName)
            ?.TradeTypeId;

        if (tradeTypeId != null) return (int)tradeTypeId;
        
        MissingDataHelper.InsertNewTradeType(context, TradeTypesTableName, tradeTypeName);
        throw new Exception(Consts.NoTradeTypeForBank(tradeTypeName, BankName));
    }
    
    private DbSet<T> GetTradeTypeTable(PpcapitalContext context)
    {
        return context.Set<T>();
    }
}