using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Requests;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public class SearchClient
{
    public static Task<HttpResponseWrapper<SearchResponse<T>>> Search<T>(HttpClient client, string indexName, SearchRequest request, CancellationToken token = default) =>
        client.PostResponseAsync<SearchResponse<T>, SearchRequest>($"/indexes/{indexName}/search", request, token);
}