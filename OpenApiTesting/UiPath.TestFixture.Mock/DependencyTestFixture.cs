using UiPath.TestFixture.Mock.context;
using UiPath.TestFixture.Mock.interactions;
using UiPath.TestFixture.Mock.interfaces;

namespace UiPath.TestFixture.Mock;

public class DependencyTestFixture : ITestFixture
{
    private readonly DependencyMode _mode;
    private static readonly ConfigurationSettings Configuration = new()
    {
        CollectionName = "TestFixture",
        DatabaseName = "test-data-fixture",
        LocationServiceCosmosDbAuthKey = "YubPWib8StkYZO3jCFG5hMbCfVB6ZVNyxapLAbGGh6xxT8IEvQjQSlSbYv1XEqplT3ynZ4bqojYvoMFNmYbstA==",
        LocationServiceCosmosDbEndpoint = "https://test-data-fixture.documents.azure.com:443/"
    };

    private DependencyTestFixture(DependencyMode mode, TestContext testContext)
    {
        _mode = mode;
        TestContext = testContext;
    }

    public static async Task<DependencyTestFixture> Of(DependencyMode mode)
    {
        var context = await DependencyTestContext.GetInstance(Configuration);
        return new DependencyTestFixture(mode, context);
    }

    public ISetup Setup()
    {
        return new Setup(_mode, this);
    }

    public TestContext TestContext { get; set; }

    public void Execute()
    {
        throw new NotImplementedException();
    }
}
