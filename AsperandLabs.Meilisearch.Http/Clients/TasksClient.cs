using System.Net.Http.Json;
using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public static class TasksClient
{
    public static Task<HttpResponseWrapper<MeilisearchPage<MeilisearchTask>>> Get(HttpClient client, int? limit = null, string[]? taskIds = null,
        string[]? statuses = null, string[]? types = null, string[]? indexIds = null, string? canceledBy = null, DateTime[]? beforeEnqueuedAt = null,
        DateTime[]? beforeStartedAt = null, DateTime[]? beforeFinishedAt = null, DateTime[]? afterEnqueuedAt = null, DateTime[]? afterStartedAt = null,
        DateTime[]? afterFinishedAt = null,CancellationToken token = default)
    {
        var queryString = QueryStringHelpers.Create(new Dictionary<string, object?>
        {
            ["limit"] = limit,
            ["uids"] = taskIds,
            ["statuses"] = statuses,
            ["types"] = types,
            ["indexUids"] = indexIds,
            ["canceledBy"] = canceledBy,
            ["beforeEnqueuedAt"] = beforeEnqueuedAt,
            ["beforeStartedAt"] = beforeStartedAt,
            ["beforeFinishedAt"] = beforeFinishedAt,
            ["afterEnqueuedAt"] = afterEnqueuedAt,
            ["afterStartedAt"] = afterStartedAt,
            ["afterFinishedAt"] = afterFinishedAt
        });
        
        return client.GetResponseAsync<MeilisearchPage<MeilisearchTask>>("/tasks" + queryString, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> Get(HttpClient client, int taskId, CancellationToken token = default) =>
        client.GetResponseAsync<MeilisearchTask>($"/tasks/{taskId}", token);
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> Cancel(HttpClient client, string[]? taskIds = null,
        string[]? statuses = null, string[]? types = null, string[]? indexIds = null, DateTime[]? beforeEnqueuedAt = null,
        DateTime[]? beforeStartedAt = null, DateTime[]? afterEnqueuedAt = null, DateTime[]? afterStartedAt = null,
        CancellationToken token = default)
    {    
        var response = client.PostAsJsonAsync("/tasks/cancel", new
        {
            uids = taskIds,
            statuses,
            types,
            indexUids = indexIds,
            beforeEnqueuedAt,
            beforeStartedAt,
            afterEnqueuedAt,
            afterStartedAt
        }, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> Delete(HttpClient client, string[]? taskIds = null,
        string[]? statuses = null, string[]? types = null, string? canceledBy = null, string[]? indexIds = null, DateTime[]? beforeEnqueuedAt = null,
        DateTime[]? beforeStartedAt = null, DateTime[]? afterEnqueuedAt = null, DateTime[]? beforeFinishedAt = null, DateTime[]? afterFinishedAt = null,
        DateTime[]? afterStartedAt = null, CancellationToken token = default)
    {    
        var response = client.PostAsJsonAsync("/tasks/cancel", new
        {
            uids = taskIds,
            statuses,
            types,
            indexUids = indexIds,
            canceledBy,
            beforeEnqueuedAt,
            beforeStartedAt,
            beforeFinishedAt,
            afterEnqueuedAt,
            afterStartedAt,
            afterFinishedAt
        }, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
}