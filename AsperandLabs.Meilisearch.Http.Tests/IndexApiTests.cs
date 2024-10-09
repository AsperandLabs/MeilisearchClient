using AsperandLabs.Meilisearch.Http.Clients;
using AsperandLabs.Meilisearch.Http.Enums;
using AsperandLabs.Meilisearch.Http.Helpers;

namespace AsperandLabs.Meilisearch.Http.Tests;

[TestClass]
public class IndexApiTests
{
    private readonly HttpClient _client = HttpClients.ValidLocalHttpClient();
    
    [TestMethod]
    public async Task CreateAndDeleteIndex()
    {
        var createTask = await  IndexApi.Create(_client, "CreateDeleteIndexTest", "primaryKey");
        
        Assert.IsNotNull(createTask);
        Assert.IsTrue(createTask.WasSuccessful);
        Assert.IsNotNull(createTask.Result);
        
        var finalTask = await createTask.Result.WaitForCompletion(_client);
        
        Assert.IsTrue(finalTask.WasSuccessful);
        Assert.IsNotNull(finalTask.Result);
        Assert.AreEqual(finalTask.Result.Status, MeilisearchTaskStatus.Succeeded);
        
        var deleteTask = await IndexApi.Delete(_client, "CreateDeleteIndexTest");
        
        Assert.IsNotNull(deleteTask);
        Assert.IsTrue(deleteTask.WasSuccessful);
        Assert.IsNotNull(deleteTask.Result);
        
        var finalDeleteTask = await deleteTask.Result.WaitForCompletion(_client);
        
        Assert.IsTrue(finalDeleteTask.WasSuccessful);
        Assert.IsNotNull(finalDeleteTask.Result);
        Assert.AreEqual(finalDeleteTask.Result.Status, MeilisearchTaskStatus.Succeeded);
    }
    
    
    [TestMethod]
    public async Task DeleteNonExistentIndex()
    {
        var deleteTask = await IndexApi.Delete(_client, "NotRealIndex");
        
        Assert.IsNotNull(deleteTask);
        Assert.IsTrue(deleteTask.WasSuccessful);
        Assert.IsNotNull(deleteTask.Result);
        
        var finalDeleteTask = await deleteTask.Result.WaitForCompletion(_client);
        
        Assert.IsTrue(finalDeleteTask.WasSuccessful);
        Assert.IsNotNull(finalDeleteTask.Result);
        Assert.AreEqual(finalDeleteTask.Result.Status, MeilisearchTaskStatus.Failed);
        Assert.IsNotNull(finalDeleteTask.Result.Error);
        Assert.AreEqual(finalDeleteTask.Result.Error.Code, "index_not_found");
    }
    
    
    
    [TestMethod]
    public async Task GetNonExistentIndex()
    {
        var getResponse = await IndexApi.Get(_client, "NotRealIndex");
        
        Assert.IsNotNull(getResponse);
        Assert.IsFalse(getResponse.WasSuccessful);
        Assert.IsNotNull(getResponse.Error);
        Assert.AreEqual(getResponse.Error.Code, "index_not_found");
    }
}