using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Requests;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public static class FacetSearchApi
{
    public static Task<HttpResponseWrapper<FacetSearchResponse>> Search(HttpClient client, string indexName, FacetSearchRequest request, CancellationToken token = default) => 
        client.PostResponseAsync<FacetSearchResponse, FacetSearchRequest>($"/indexes/{indexName}/facet-search", request, token);
}