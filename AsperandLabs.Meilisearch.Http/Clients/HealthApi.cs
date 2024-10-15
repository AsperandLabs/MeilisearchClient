using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public static class HealthApi
{
    public static Task<HttpResponseWrapper<HealthResponse>> Get(HttpClient client, CancellationToken token = default) =>
        client.GetResponseAsync<HealthResponse>("/health", token);
}