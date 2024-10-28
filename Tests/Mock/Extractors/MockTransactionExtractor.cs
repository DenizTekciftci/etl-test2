using AutoFixture;
using DataAccess.FileAccess.Extractors;

namespace Tests.Mock.Extractors;

public class MockTransactionExtractor(IFixture fixture) : IExtractor<MockTransaction>
{
    public List<MockTransaction> Extract<T2>(Func<T2, List<MockTransaction>>? getRecords = null)
    {
        return fixture
            .Build<MockTransaction>()
            .CreateMany(5)
            .ToList();
    }
}