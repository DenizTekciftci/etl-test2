using DataAccess.DatabaseAccess.Banks;
using DataAccess.DatabaseAccess.Helpers;
using DataAccess.DatabaseAccess.Models;
using DataAccess.FileAccess.BankFileTypes;
using DataAccess.FileAccess.BankFileTypes.EFG;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DatabaseAccess.Transformers;
public class HoldingsTransformer
{
    private readonly IBank _bank;
    private readonly List<DexReturnDate> _returnDates;
    private readonly IInstrumentHelper _instrumentHelper;
    private readonly IAccountHelper _accountHelper;
    public HoldingsTransformer(PpcapitalContext context, IInstrumentHelper instrumentHelper, IAccountHelper accountHelper, IBank bank)
    {
        _bank = bank;
        _instrumentHelper = instrumentHelper;
        _accountHelper = accountHelper;
        _returnDates = context.DexReturnDates.OrderByDescending(r => r.ReturnDate).ToList();
    }
    public DexBankHoldingsCash CreateCashHolding(BankHolding bankHolding)
    {
        var bankCashHolding = new DexBankHoldingsCash();
        bankCashHolding.AccountId = _accountHelper.GetAccountId(bankHolding.AccountName, bankHolding.Currency, _bank.GetBankId());
        bankCashHolding.HoldingDate = _returnDates.First(r => r.ReturnDate <= bankHolding.HoldingDate).ReturnDate;
        bankCashHolding.Amount = bankHolding.Amount ?? 0;
        bankCashHolding.Currency = bankHolding.Currency;
        
        return bankCashHolding;
    }
    
    public DexBankHoldingsInstrument CreateInstrumentHolding(BankHolding bankHolding)
    {
        var bankInstrumentHolding = new DexBankHoldingsInstrument();
        bankInstrumentHolding.AccountId = _accountHelper.GetAccountId(bankHolding.AccountName, bankHolding.Currency, _bank.GetBankId());
        bankInstrumentHolding.InstrumentId = _instrumentHelper.GetInstrumentIdByIsin(bankHolding.ISIN);
        bankInstrumentHolding.HoldingDate = _returnDates.First(r => r.ReturnDate <= bankHolding.HoldingDate).ReturnDate;
        bankInstrumentHolding.Quantity = bankHolding.Quantity ?? 0;
        bankInstrumentHolding.Currency = bankHolding.Currency;
        
        return bankInstrumentHolding;
    }
}