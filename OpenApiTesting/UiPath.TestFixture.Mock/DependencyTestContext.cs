using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using UiPath.TestFixture.Mock.context;

namespace UiPath.TestFixture.Mock;

public class DependencyTestContext : TestContext
{
    private readonly CosmosClient _client;
    private readonly ConfigurationSettings _settings;
    private Container _container;

    private DependencyTestContext(ConfigurationSettings settings)
    {
        _settings = settings;
        _client = new CosmosClientBuilder(settings.LocationServiceCosmosDbEndpoint,
            settings.LocationServiceCosmosDbAuthKey).Build();
    }

    private async Task InitializeAsync()
    {
        var clientResponse = await _client.CreateDatabaseIfNotExistsAsync(_settings.DatabaseName);
        var containerResponse = await clientResponse.Database.DefineContainer(name: _settings.CollectionName, partitionKeyPath: "/_partitionKey").CreateIfNotExistsAsync();
        _container = containerResponse.Container;
    }

    public override async void Publish<TReturnResult>(TReturnResult mockReturn)
    {
        await _container.UpsertItemAsync(mockReturn, PartitionKey.None);
        Console.WriteLine("publish test result to fixture store");
    }

    public static async Task<DependencyTestContext> GetInstance(ConfigurationSettings settings)
    {
        var context = new DependencyTestContext(settings);
        await context.InitializeAsync();
        return context;
    }
}
