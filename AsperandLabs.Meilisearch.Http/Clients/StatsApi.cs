using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Responses;
using AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

namespace AsperandLabs.Meilisearch.Http.Clients;

public static class StatsApi
{
    public static Task<HttpResponseWrapper<AllStatsResponse>> GetAll(HttpClient client, CancellationToken token = default) =>
        client.GetResponseAsync<AllStatsResponse>("/stats", token);
    public static Task<HttpResponseWrapper<IndexStats>> GetIndexStats(HttpClient client, string indexId, CancellationToken token = default) =>
        client.GetResponseAsync<IndexStats>($"/index/{indexId}/stats", token);
}