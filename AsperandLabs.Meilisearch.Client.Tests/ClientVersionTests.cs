namespace AsperandLabs.Meilisearch.Client.Tests;

[TestFixture]
public class ClientVersionTests
{   
    private MeilisearchClient _client => new("http://localhost:7700", "HTHcCpWQZbDNlk3WpmEmyEAzbG3RQpbOTsE9fUOxy5o");
    [Test]
    public async Task CanConnectAndGetVersion()
    {
        var client = _client;
        var version = await client.GetVersion();
        
        Assert.IsNotNull(version);
    }
}