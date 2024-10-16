using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Requests;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public static class KeysApi
{
    public static Task<HttpResponseWrapper<MeilisearchPage<MeilisearchKey>>> GetKeys(HttpClient client, int? offset = null, int? limit = null, CancellationToken token = default)
    {
        var queryString = QueryStringHelpers.Create(new Dictionary<string, object?>
        {
            ["offset"] = offset,
            ["limit"] = limit
        });
        return client.GetResponseAsync<MeilisearchPage<MeilisearchKey>>("/keys"+queryString, token);
    } 
    
    public static Task<HttpResponseWrapper<MeilisearchPage<MeilisearchKey>>> GetById(HttpClient client, Guid id, CancellationToken token = default) =>
        client.GetResponseAsync<MeilisearchPage<MeilisearchKey>>($"/keys/{id}", token);
    
    public static Task<HttpResponseWrapper<MeilisearchPage<MeilisearchKey>>> GetByName(HttpClient client, string name, CancellationToken token = default) =>
        client.GetResponseAsync<MeilisearchPage<MeilisearchKey>>($"/keys/{name}", token);
    
    public static Task<HttpResponseWrapper<MeilisearchKey>> Create(HttpClient client, CreateKeyRequest key, CancellationToken token = default) =>
        client.PostResponseAsync<MeilisearchKey, CreateKeyRequest>("/keys", key, token);
    
    public static Task<HttpResponseWrapper<UpdateKeyResponse>> UpdateById(HttpClient client, Guid id, UpdateKeyRequest key, CancellationToken token = default) =>
        client.PatchResponseAsync<UpdateKeyResponse, UpdateKeyRequest>($"/keys/{id}", key, token);
    
    public static Task<HttpResponseWrapper<UpdateKeyResponse>> UpdateByName(HttpClient client, string name, UpdateKeyRequest key, CancellationToken token = default) =>
        client.PatchResponseAsync<UpdateKeyResponse, UpdateKeyRequest>($"/keys/{name}", key, token);
    
    public static Task<HttpResponseWrapper<MeilisearchResponse>> DeleteById(HttpClient client, Guid id, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchResponse>($"/keys/{id}", token);
    
    public static Task<HttpResponseWrapper<MeilisearchResponse>> DeleteByName(HttpClient client, string name, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchResponse>($"/keys/{name}", token);
}