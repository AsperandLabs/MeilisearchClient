using System.Net.Http.Headers;
using AsperandLabs.Meilisearch.Client.Helpers;
using AsperandLabs.Meilisearch.Domain;
using AsperandLabs.Meilisearch.Http.Clients;
using AsperandLabs.Meilisearch.Http.Enums;
using AsperandLabs.Meilisearch.Http.Helpers;

namespace AsperandLabs.Meilisearch.Client;

public class MeilisearchClient
{
    private readonly HttpClient _httpClient;
    
    public MeilisearchClient(string url, string apiKey)
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri(url);
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
    }
    
    public async Task<bool> IndexExistsAsync(string indexName, CancellationToken cancellationToken = default) 
    {
        var response = await IndexApi.Get(_httpClient, indexName, cancellationToken);
        return response.WasSuccessful;
    }
    
    public async Task<IndexClient<T>> GetIndex<T>(string indexName, CancellationToken cancellationToken = default)
    {
        var response = await IndexApi.Get(_httpClient, indexName, cancellationToken);
        var result = response.UnwrapValue();
        
        return new IndexClient<T>(_httpClient, result);
    }
    
    public async Task<IEnumerable<string>> GetAllIndexNames(int? limit, int? offset, CancellationToken cancellationToken = default)
    {
        var response = await IndexApi.GetAll(_httpClient, limit, offset, token: cancellationToken);
        var result = response.UnwrapValue();

        return result.Indices.Select(x => x.Id);

    }
    
    public async Task<IndexClient<T>> CreateIndex<T>(string indexName, CancellationToken cancellationToken = default)
    {
        if(await IndexExistsAsync(indexName, cancellationToken))
            ExceptionHelpers.ThrowException("Index already exists");

        var id = ReflectionHelpers.GetIdName<T>();
        var response = await IndexApi.Create(_httpClient, indexName, id, cancellationToken);
        var result = response.UnwrapValue();
        var taskResponse = await result.WaitForCompletion(_httpClient, cancellationToken);
        var task = taskResponse.UnwrapValue();
        
        return await GetIndex<T>(task.IndexId!, cancellationToken);
    }
    
    public async Task<bool> DeleteIndex(string indexName, bool waitForCompletion = false, CancellationToken cancellationToken = default)
    {
        var response = await IndexApi.Delete(_httpClient, indexName, cancellationToken);
        var task = response.UnwrapValue();

        if (!waitForCompletion)
            return true;
        
        var waitResponse = await task.WaitForCompletion(_httpClient, cancellationToken);
        var finalTask = waitResponse.UnwrapValue();
        
        return finalTask.Status == MeilisearchTaskStatus.Succeeded;
    }
    
    public async Task<VersionResponse> GetVersion()
    {
        var response = await VersionApi.Get(_httpClient);
        return response.UnwrapValue();
    }
}