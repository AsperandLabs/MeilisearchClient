using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class MeilisearchPage<T>
{
    [JsonPropertyName("results")]
    public List<T> Results { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }
}