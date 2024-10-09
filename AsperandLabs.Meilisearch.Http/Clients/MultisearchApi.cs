using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Requests;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public class MultisearchApi
{
    public static Task<HttpResponseWrapper<MultisearchResponse<T>>> Multisearch<T>(HttpClient client, MultiSearchRequest request, CancellationToken token = default) => 
        client.PostResponseAsync<MultisearchResponse<T>, MultiSearchRequest>("/multi-search", request, token);
    
    public static Task<HttpResponseWrapper<FacetSearchResponse>> FederatedSearch(HttpClient client, FacetSearchRequest request, CancellationToken token = default) => 
        client.PostResponseAsync<FacetSearchResponse, FacetSearchRequest>("/multi-search", request, token);

}