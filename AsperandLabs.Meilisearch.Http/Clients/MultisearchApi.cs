using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Requests.Multisearch;
using AsperandLabs.Meilisearch.Http.Responses;
using AsperandLabs.Meilisearch.Http.Responses.Multisearch;

namespace AsperandLabs.Meilisearch.Http.Clients;

public static class MultisearchApi
{
    public static Task<HttpResponseWrapper<MultisearchResponse<T>>> Multisearch<T>(HttpClient client, List<MultiSearchRequest> request, CancellationToken token = default) => 
        client.PostResponseAsync<MultisearchResponse<T>, List<MultiSearchRequest>>("/multi-search", request, token);
    
    public static Task<HttpResponseWrapper<FederatedSearchResponse>> FederatedSearch(HttpClient client, List<FederatedSearchRequest> request, CancellationToken token = default) => 
        client.PostResponseAsync<FederatedSearchResponse, List<FederatedSearchRequest>>("/multi-search", request, token);
}