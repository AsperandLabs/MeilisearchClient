using System.Net;
using System.Text.Json;

namespace AsperandLabs.Meilisearch.Http.Helpers;

public class HttpResponseWrapper<T>
{
    public T? Result { get; set; }
    public string RawResult { get; set; }
    public HttpStatusCode StatusCode { get; set; }
    public bool WasSuccessful { get; set; }

    public static async Task<HttpResponseWrapper<T>> FromResponse(Task<HttpResponseMessage> responseTask, CancellationToken token)
    {
        var response = await responseTask;
        var body = await response.Content.ReadAsStringAsync(token);
        var wrapper = new HttpResponseWrapper<T>
        {
            WasSuccessful = response.IsSuccessStatusCode,
            StatusCode = response.StatusCode,
            RawResult = body
        };

        if (response.IsSuccessStatusCode)
            wrapper.Result = JsonSerializer.Deserialize<T>(body);
        
        return wrapper;
    }
}