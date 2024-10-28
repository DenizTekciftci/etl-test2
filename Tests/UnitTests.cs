using AutoFixture;
using AutoFixture.AutoMoq;
using DataAccess.DatabaseAccess.Helpers;
using Moq;
using Microsoft.EntityFrameworkCore;
using DataAccess.DatabaseAccess.Models;
using DataAccess.DatabaseAccess.Transformers;
using DataAccess.FileAccess.BankFileTypes.Nordnet;
using DataAccess.FileAccess.FileProcessors;
using Serilog;
using Tests.Mock;
using Tests.Mock.Extractors;

namespace MyProject.Tests
{
    [SetUpFixture]
    public class DbContextTestsSetup
    {
        protected IFixture Fixture { get; private set; }

        [OneTimeSetUp]
        public void GlobalSetup()
        {
            // AutoFixture setup with AutoMoq
            Fixture = new Fixture().Customize(new AutoMoqCustomization());
            // foreach (var behavior in Fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList())
            //     Fixture.Behaviors.Remove(behavior);
            // Fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }
    }

    [TestFixture]
    public class MyDbContextTests : DbContextTestsSetup
    {
        private Mock<PpcapitalContext> _mockContext;

        [SetUp]
        public void Setup()
        {
            // Arrange: Setup a mocked DbContext
            _mockContext = Fixture.Freeze<Mock<PpcapitalContext>>();
            
            // Setup the mocked DbSet with test data
            var securityTransactions = Fixture
                .Build<DexSecurityTransaction>()
                .Without(s => s.Account)
                .Without(s => s.CurrencyNavigation)
                .Without(s => s.Instrument)
                .Without(s => s.TradeType)
                .CreateMany(5)
                .ToList();
            
            var mockDbSet = new Mock<DbSet<DexSecurityTransaction>>();
            mockDbSet.As<IQueryable<DexSecurityTransaction>>().Setup(m => m.Provider).Returns(securityTransactions.AsQueryable().Provider);
            mockDbSet.As<IQueryable<DexSecurityTransaction>>().Setup(m => m.Expression).Returns(securityTransactions.AsQueryable().Expression);
            mockDbSet.As<IQueryable<DexSecurityTransaction>>().Setup(m => m.ElementType).Returns(securityTransactions.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<DexSecurityTransaction>>().Setup(m => m.GetEnumerator()).Returns(securityTransactions.GetEnumerator());

            // Setup DbContext to return the mocked DbSet
            _mockContext.Setup(c => c.DexSecurityTransactions).Returns(mockDbSet.Object);
        }

        [Test]
        public async Task QueryItemsFromDbContext_ReturnsCorrectItems()
        {
            // Act: Query the context directly
            var result = _mockContext.Object.DexSecurityTransactions.ToList();

            // Assert: Verify that the returned items are correct
            Assert.That(result.Count, Is.EqualTo(5));
        }

        [Test]
        public async Task CreateTransactionWithCostThatHasNoCashImpact()
        {
            // Arrange
            var instrumentHelper = new MockInstrumentHelper();
            var accountHelper =  new MockAccountHelper();
            var bank = new MockBank();
            
            var transaction = Fixture.Create<Transaction>();
            var transactionTransformer = new TransactionTransformer(instrumentHelper, accountHelper, bank);
            var costTransformer = new CostTransformer(accountHelper, bank);
            
            // Act: Query the context directly
            var transformed = transactionTransformer.CreateSecurityTransaction(transaction);
            var costs = costTransformer.CreateAllCosts(transaction);

            // Assert
            Assert.That(transformed.InputDate, Is.EqualTo(DateTime.Today));
            Assert.That(costs.Count, Is.EqualTo(1));
            foreach (var cost in costs)
                Assert.That(cost.CashImpact, Is.EqualTo(0));
        }
        
        [Test]
        public async Task Process()
        {
            // Arrange
            var accountHelper =  new MockAccountHelper();
            var mockDbFactory = new Mock<IDbContextFactory<PpcapitalContext>>();
            var instrumentHelper = new Mock<IInstrumentHelper>();
            
            var mockTransformerFactory = new TransformerFactory(
                mockDbFactory.Object,
                instrumentHelper.Object,
                accountHelper);
            
            var processor = new BaseTransactionFileProcessor<MockTransaction>(
                new MockTransactionExtractor(Fixture),
                mockTransformerFactory,
                new MockLoader(), // Asserts on costs,
                new MockBank(),
                new Mock<ILogger>().Object
                );
            
            // Act
            processor.Process();
            
            // Asserts happen in the MockLoader since BaseTransactionFileProcessor is closed off and does not return anything
        }
    }
}