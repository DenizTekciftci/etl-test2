using DataAccess.DatabaseAccess.Infrastructure;
using DataAccess.DatabaseAccess.Models;

namespace DataAccess.DatabaseAccess.Helpers;

public static class MissingDataHelper
{
    public static void InsertNewAccount(PpcapitalContext context, string accountName, string currency, int bankId)
    {
        var newAccount = new DexClientAccountNew
        {
            InputDate = DateTime.Today,
            Account = accountName,
            Currency = currency,
            BankId = bankId
        };

        context.DexClientAccountNews.AddIfNotExists(newAccount,
            x =>
                x.Account == newAccount.Account &&
                x.Currency == newAccount.Currency &&
                x.BankId == newAccount.BankId
        );
        
        context.SaveChanges();
    }
    
    public static void InsertNewDepot(PpcapitalContext context, string depotName, int bankId)
    {
        var newDepot = new DexClientDepotsNew()
        {
            InputDate = DateTime.Today,
            Depot = depotName,
            BankId = bankId
        };
        
        var entry = context.DexClientDepotsNews.AddIfNotExists(newDepot,
            x => x.Depot == newDepot.Depot && x.BankId == newDepot.BankId);
    }
    
    public static void InsertNewTradeType(PpcapitalContext context, string refTable, string bankTypName, int? isinExists = null)
    {
        var newTradeType = new DexTradeTypeNew()
        {
            InputDate = DateTime.Today,
            RefTable = refTable,
            BankTypeName = bankTypName,
            IsinExists = (sbyte?)isinExists,
        };
        
        var entry = context.DexTradeTypeNews.AddIfNotExists(newTradeType,
            x => x.RefTable == newTradeType.RefTable && x.BankTypeName == newTradeType.BankTypeName);
        context.SaveChanges();
    }
    
    public static void InsertNewInstrument(PpcapitalContext context, string isin)
    {
        var instrumentsNew = new DexInstrumentsNew()
        {
            InputDate = DateTime.Today,
            Isin = isin,
        };
        
        var entry = context.DexInstrumentsNews.AddIfNotExists(instrumentsNew,
            x => x.Isin == instrumentsNew.Isin);
        context.SaveChanges();
        var lis = context.DexInstrumentsNews.ToList();
    }
    
    // public static void InsertNewFundCode(PPCapitalContext context, string isin)
    // {
    //     var instrumentsNew = new DexInstrumentsNew()
    //     {
    //         InputDate = DateTime.Today,
    //         Isin = isin,
    //     };
    //     
    //     var entry = context.DexInstrumentsNews.AddIfNotExists(instrumentsNew,
    //         x => x.Isin == instrumentsNew.Isin);
    //     context.SaveChanges();
    //     var lis = context.DexInstrumentsNews.ToList();
    // }
}