using AsperandLabs.Meilisearch.Client.Attributes;
using AsperandLabs.Tests.Shared;

namespace AsperandLabs.Meilisearch.Client.Tests;

public class ClientIndexTests
{
    private MeilisearchClient _client => new("http://localhost:7700", "HTHcCpWQZbDNlk3WpmEmyEAzbG3RQpbOTsE9fUOxy5o");
    
    [Test]
    public async Task CanCreateAndDeletePropertyIndex()
    {
        var client = _client;
        var index = await client.CreateIndex<GoodPropertyTestType>(TestHelpers.TestName());
        Assert.IsNotNull(index);
        
        var isDeleted = await client.DeleteIndex(index.Name, true);     
        Assert.IsTrue(isDeleted);

        var isExisting = await client.IndexExistsAsync(index.Name);
        Assert.IsFalse(isExisting);
    }
    
    
    
    [Test]
    public async Task CanCreateAndDeleteAttributeIndex()
    {
        var client = _client;
        var index = await client.CreateIndex<GoodAttributeTestType>(TestHelpers.TestName());
        Assert.IsNotNull(index);
        
        var isDeleted = await client.DeleteIndex(index.Name, true);     
        Assert.IsTrue(isDeleted);

        var isExisting = await client.IndexExistsAsync(index.Name);
        Assert.IsFalse(isExisting);
    }
    
    
    [Test]
    public void CantCreateBadPropertyIndex()
    {
        var client = _client;
        var test = Assert.ThrowsAsync<MeilisearchException>(
            async () => await client.CreateIndex<BadPropertyTestType>(TestHelpers.TestName())
        );
    }
}

public class GoodPropertyTestType
{
    public int Id { get; set; }
}

public class BadPropertyTestType 
{
    public int NotAnId { get; set; }
}

public class GoodAttributeTestType
{
    [Id]
    public int MightBeAnId { get; set; }
}