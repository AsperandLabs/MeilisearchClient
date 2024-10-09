using System.Net.Http.Json;
using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public static class IndexApi
{
    public static Task<HttpResponseWrapper<MeilisearchIndex>> Get(HttpClient client, string indexName, CancellationToken token = default) =>
        client.GetResponseAsync<MeilisearchIndex>($"/indexes/{indexName}", token);

    public static Task<HttpResponseWrapper<GetAllIndexesResponse>> GetAll(HttpClient client, int? offset = null, int? limit = null, CancellationToken token = default)
    {
        var queryString = QueryStringHelpers.Create(new() { ["offset"] = offset, ["limit"] = limit });
        return client.GetResponseAsync<GetAllIndexesResponse>("/indexes" + queryString, token);
    }

    public static Task<HttpResponseWrapper<MeilisearchTask>> Create(HttpClient client, string indexId, string primaryKey, CancellationToken token = default)
    {
        var response = client.PostAsJsonAsync("/indexes", new { primaryKey, uid = indexId }, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdatePrimaryKey(HttpClient client, string indexId, string primaryKey, CancellationToken token = default)
    {
        var response = client.PatchAsJsonAsync($"/indexes/{indexId}", new { primaryKey }, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }

    public static Task<HttpResponseWrapper<MeilisearchTask>> Delete(HttpClient client, string indexId, CancellationToken token = default) =>
        client.DeleteResponseAsync<MeilisearchTask>($"/indexes/{indexId}", token);

    public static Task<HttpResponseWrapper<MeilisearchTask>> SwapIndex(HttpClient client, string firstIndexId, string secondIndexId, CancellationToken token = default) =>
        client.PostResponseAsync<MeilisearchTask, List<string>>("/swap-indexes", new List<string>
        {
            firstIndexId, secondIndexId
        }, token);
}