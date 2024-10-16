using System.Net;

namespace AsperandLabs.Meilisearch.Http.Helpers;

public class MeilisearchResponse
{
    public string RawResult { get; init; }
    public HttpStatusCode StatusCode { get; init; }
    public bool WasSuccessful { get; private set; }
    
    public static async Task<MeilisearchResponse> FromResponse(Task<HttpResponseMessage> responseTask, CancellationToken token)
    {
        var response = await responseTask;
        var body = await response.Content.ReadAsStringAsync(token);
        return new MeilisearchResponse
        {
            WasSuccessful = response.IsSuccessStatusCode,
            StatusCode = response.StatusCode,
            RawResult = body
        };
    }
}