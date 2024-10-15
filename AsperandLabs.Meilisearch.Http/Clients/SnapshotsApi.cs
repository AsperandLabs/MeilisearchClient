using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public class SnapshotsApi
{   
    public static Task<HttpResponseWrapper<MeilisearchTask>> Create(HttpClient client, CancellationToken token = default) =>
        client.PostResponseAsync<MeilisearchTask>("/snapshots", token);
}