using AsperandLabs.Meilisearch.Domain;
using AsperandLabs.Meilisearch.Http.Helpers;

namespace AsperandLabs.Meilisearch.Http.Clients;

public static class VersionApi
{
    public static Task<HttpResponseWrapper<VersionResponse>> Get(HttpClient client, CancellationToken token = default) =>
        client.GetResponseAsync<VersionResponse>("/version", token);
}