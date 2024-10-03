using System.Net.Http.Json;
using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public static class IndexClient
{
    public static Task<HttpResponseWrapper<MeilisearchIndex>> Get(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.GetAsync($"/indexes/{indexName}");
        return HttpResponseWrapper<MeilisearchIndex>.FromResponse(response, token);
    }

    public static Task<HttpResponseWrapper<GetAllIndexesResponse>> GetAll(HttpClient client, int? offset = null, int? limit = null, CancellationToken token = default)
    {
        var queryString = QueryStringHelpers.Create(new() { ["offset"] = offset, ["limit"] = limit });
        var response = client.GetAsync("/indexes" + queryString);
        return HttpResponseWrapper<GetAllIndexesResponse>.FromResponse(response, token);
    }

    public static Task<HttpResponseWrapper<MeilisearchTask>> Create(HttpClient client, string indexId, string primaryKey, CancellationToken token = default)
    {
        var response = client.PostAsync("/indexes", JsonContent.Create(new { primaryKey, uid = indexId }));
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }

    public static Task<HttpResponseWrapper<MeilisearchTask>> UpdatePrimaryKey(HttpClient client, string indexId, string primaryKey, CancellationToken token = default)
    {
        var response = client.PatchAsync($"/indexes/{indexId}", JsonContent.Create(new { primaryKey }));
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }

    public static Task<HttpResponseWrapper<MeilisearchTask>> Delete(HttpClient client, string indexId, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexId}");
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }

    public static Task<HttpResponseWrapper<MeilisearchTask>> SwapIndex(HttpClient client, string firstIndexId, string secondIndexId, CancellationToken token = default)
    {
        var response = client.PostAsync("/swap-indexes", JsonContent.Create(new List<string>
        {
            firstIndexId, secondIndexId
        }));
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
}