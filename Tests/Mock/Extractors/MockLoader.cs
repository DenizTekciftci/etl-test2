using DataAccess.DatabaseAccess.Loaders;
using DataAccess.DatabaseAccess.Models;

namespace Tests.Mock.Extractors;

public class MockLoader : ILoader
{
    public void Load(List<DexCost> dexCosts)
    {
        foreach (var cost in dexCosts)
            Assert.That(cost.CashImpact, Is.EqualTo(1));
    }

    public void Load(List<DexBankHoldingsCash> cashHoldings)
    {
    }

    public void Load(List<DexBankHoldingsInstrument> instrumentHoldings)
    {
    }

    public void Load(List<(DexCashTransaction, List<DexCost>)> transformed)
    {
        foreach ((DexCashTransaction transaction, List<DexCost> costs) in transformed)
        {
            foreach (var cost in costs)
                Assert.That(cost.CashImpact, Is.EqualTo(0));
        }
    }

    public void Load(List<(DexDividendTransaction, List<DexCost>)> transformed)
    {
        foreach ((DexDividendTransaction transaction, List<DexCost> costs) in transformed)
        {
            foreach (var cost in costs)
                Assert.That(cost.CashImpact, Is.EqualTo(0));
        }
    }

    public void Load(List<(DexSecurityTransaction, List<DexCost>)> transformed)
    {
        foreach ((DexSecurityTransaction transaction, List<DexCost> costs) in transformed)
        {
            foreach (var cost in costs)
                Assert.That(cost.CashImpact, Is.EqualTo(0));
        }
    }

    public void Load(List<(DexBondCoupon, List<DexCost>)> transformed)
    {
        foreach ((DexBondCoupon transaction, List<DexCost> costs) in transformed)
        {
            foreach (var cost in costs)
                Assert.That(cost.CashImpact, Is.EqualTo(0));
        }
    }
    
    public void Load(DexStagingSecurityTransaction transaction, List<DexStagingCost> costs)
    {
    }

    public void Load(DexStagingDividendTransaction transaction, List<DexStagingCost> costs)
    {
    }

    public void Load(DexStagingCashTransaction transaction, List<DexStagingCost> costs)
    {
    }

    public void Load(DexStagingBondCoupon transaction, List<DexStagingCost> costs)
    {
    }

    public void Load(List<DexFundCode> fundCodes)
    {
    }


    public void Load(List<DexInstrumentCntryAlloc> countryAllocs)
    {
    }

    public void Load(List<DexInstrumentSectorAlloc> sectorAllocs)
    {
    }

    public void Load(List<DexPpFundAssetClassAlloc> sectorAllocs)
    {
    }

    public void BulkLoad(List<DexComparisonsCash> cashComparisons)
    {
    }

    public void BulkLoad(List<DexComparisonsInstrument> instrumentComparisons)
    {
    }

    public void BulkLoad(List<DexClientCashHolding> cashHoldings)
    {
    }

    public void BulkLoad(List<DexClientInstHolding> instHoldings)
    {
    }
}