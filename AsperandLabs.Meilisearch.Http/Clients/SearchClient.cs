using System.Net.Http.Json;
using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Requests;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public class SearchClient
{
    public static Task<HttpResponseWrapper<SearchResponse<T>>> Search<T>(HttpClient client, string indexName, SearchRequest request, CancellationToken token = default)
    {
        var response = client.PostAsJsonAsync($"/indexes/{indexName}/search", request, token);
        return HttpResponseWrapper<SearchResponse<T>>.FromResponse(response, token);
    }
}