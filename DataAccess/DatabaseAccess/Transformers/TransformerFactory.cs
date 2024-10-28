using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Transformers;

public interface ITransformerFactory
{
    public TransactionTransformer CreateTransactionTransformer(IBank bank);
    public CostTransformer CreateCostTransfomer(IBank bank);
    public HoldingsTransformer CreateHoldingsTransformer(IBank bank);
}

public class TransformerFactory(IDbContextFactory<PpcapitalContext> contextFactory, IInstrumentHelper instrumentHelper, IAccountHelper accountHelper) : ITransformerFactory
{
    public TransactionTransformer CreateTransactionTransformer(IBank bank)
    {
        return new TransactionTransformer(instrumentHelper, accountHelper, bank);
    }

    public CostTransformer CreateCostTransfomer(IBank bank)
    {
        return new CostTransformer(accountHelper, bank);
    }

    public HoldingsTransformer CreateHoldingsTransformer(IBank bank)
    {
        var context = contextFactory.CreateDbContext();
        return new HoldingsTransformer(context, instrumentHelper, accountHelper, bank);
    }
}