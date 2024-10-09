using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using AsperandLabs.Meilisearch.Http.Converters;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Helpers;

public class HttpResponseWrapper<T>
{
    public T? Result { get; set; }
    public MeilisearchError? Error { get; set; }
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
        {
            wrapper.Result = JsonSerializer.Deserialize<T>(body, new JsonSerializerOptions
            {
                Converters =
                {
                    new JsonStringEnumConverter(JsonNamingPolicy.CamelCase),
                    new Iso8601DurationConverter()
                }
            });
        }
        else
        {
            wrapper.Error = JsonSerializer.Deserialize<MeilisearchError>(body);
        }

        return wrapper;
    }
}