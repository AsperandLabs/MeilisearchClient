using System.Net.Http.Json;
using AsperandLabs.Meilisearch.Http.Helpers;
using AsperandLabs.Meilisearch.Http.Requests;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Clients;

public class SettingsClient
{
    public static Task<HttpResponseWrapper<MeilisearchTask>> Update<T>(HttpClient client, string indexName, UpdateSettingsRequest request, CancellationToken token = default)
    {
        var response = client.PatchAsJsonAsync($"/indexes/{indexName}/settings", request, token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
    
    public static Task<HttpResponseWrapper<MeilisearchTask>> Reset<T>(HttpClient client, string indexName, CancellationToken token = default)
    {
        var response = client.DeleteAsync($"/indexes/{indexName}/settings", token);
        return HttpResponseWrapper<MeilisearchTask>.FromResponse(response, token);
    }
}