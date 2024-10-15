using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using AsperandLabs.Meilisearch.Http.Converters;
using AsperandLabs.Meilisearch.Http.Responses;

namespace AsperandLabs.Meilisearch.Http.Helpers;

public class HttpResponseWrapper<T>
{
    public T? Result { get; private set; }
    public MeilisearchError? Error { get; private set; }
    public string RawResult { get; init; }
    public HttpStatusCode StatusCode { get; init; }
    public bool WasSuccessful { get; private set; }

    private static JsonSerializerOptions SerializerOptions { get; } = new()
    {
        Converters =
        {
            new JsonStringEnumConverter(JsonNamingPolicy.CamelCase),
            new Iso8601DurationConverter(),
            new FederatedSearchResultConverter()
        }
    };
    
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
            wrapper.Result = JsonSerializer.Deserialize<T>(body, SerializerOptions);
        }
        else
        {
            wrapper.Error = JsonSerializer.Deserialize<MeilisearchError>(body);
        }

        return wrapper;
    }
}