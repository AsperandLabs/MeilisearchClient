using System.Net.Http.Json;

namespace AsperandLabs.Meilisearch.Http.Helpers;

internal static class HttpClientHelpers
{
    internal static Task<HttpResponseWrapper<T>> GetResponseAsync<T>(this HttpClient httpClient, string requestUri, CancellationToken token = default)
    {
        var response = httpClient.GetAsync(requestUri, token);
        return HttpResponseWrapper<T>.FromResponse(response, token);
    }
    
    internal static Task<HttpResponseWrapper<T>> DeleteResponseAsync<T>(this HttpClient httpClient, string requestUri, CancellationToken token = default)
    {
        var response = httpClient.DeleteAsync(requestUri, token);
        return HttpResponseWrapper<T>.FromResponse(response, token);
    }
    
    internal static Task<HttpResponseWrapper<T>> PatchResponseAsync<T, TT>(this HttpClient httpClient, string requestUri, TT body, CancellationToken token = default)
    {
        var response = httpClient.PatchAsJsonAsync(requestUri, body, token);
        return HttpResponseWrapper<T>.FromResponse(response, token);
    }
    
    internal static Task<HttpResponseWrapper<T>> PostResponseAsync<T, TT>(this HttpClient httpClient, string requestUri, TT body, CancellationToken token = default)
    {
        var response = httpClient.PostAsJsonAsync(requestUri, body, token);
        return HttpResponseWrapper<T>.FromResponse(response, token);
    }
    
    internal static Task<HttpResponseWrapper<T>> PutResponseAsync<T, TT>(this HttpClient httpClient, string requestUri, TT body, CancellationToken token = default)
    {
        var response = httpClient.PutAsJsonAsync(requestUri, body, token);
        return HttpResponseWrapper<T>.FromResponse(response, token);
    }
}