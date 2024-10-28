using DataAccess.DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;
using Shared.Enums;

namespace DataAccess.DatabaseAccess.Banks;

public interface IBankFactory
{
    IBank CreateBank(Bank bank);
}

public class BankFactory(IDbContextFactory<PpcapitalContext> contextFactory) : IBankFactory
{
    public IBank CreateBank(Bank bank)
    {
        return bank switch
        {
            Bank.SparNord => new SparNord(contextFactory),
            Bank.Saxo => new SaxoBank(contextFactory),
            Bank.Nordnet => new Nordnet(contextFactory),
            Bank.RILBA => new RILBA(contextFactory),
            Bank.Bil => new BIL(contextFactory),
            Bank.Jyske => new JyskeBank(contextFactory),
            // Bank.VP => new VP(context),
            Bank.EFG => new EFG(contextFactory),
            _ => throw new ArgumentOutOfRangeException(nameof(bank), bank, null)
        };
    }
}