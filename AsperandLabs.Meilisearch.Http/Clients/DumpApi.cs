using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public class DumpApi
{
    public static Task<HttpResponseWrapper<MeilisearchTask>> Create(HttpClient client, CancellationToken token = default) =>
        client.PostResponseAsync<MeilisearchTask>("/dumps", token);
}