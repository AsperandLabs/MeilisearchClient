using AsperandLabs.Meilisearch.Http.Helpers;

namespace AsperandLabs.Meilisearch.Http.Clients;

public class ExperimentalFeaturesApi
{
    public static Task<HttpResponseWrapper<Dictionary<string, bool>>> Get(HttpClient client, CancellationToken token = default) =>
        client.GetResponseAsync<Dictionary<string, bool>>("/experimental-features", token);
    
    public static Task<HttpResponseWrapper<Dictionary<string, bool>>> Update(HttpClient client, Dictionary<string, bool> settings, CancellationToken token = default) =>
        client.PatchResponseAsync<Dictionary<string, bool>, Dictionary<string, bool>>("/experimental-features", settings, token);
}