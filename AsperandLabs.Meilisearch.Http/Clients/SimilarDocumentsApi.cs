using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Requests;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public static class SimilarDocumentsApi
{
    public static Task<HttpResponseWrapper<SimilarDocumentsResponse<T, TT>>> Create< T, TT>(HttpClient client, string indexId, SimilarDocumentsRequest<TT> request, CancellationToken token = default) =>
        client.PostResponseAsync<SimilarDocumentsResponse<T, TT>, SimilarDocumentsRequest<TT>>($"/indexes/{indexId}/similar", request, token);
}