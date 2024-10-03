using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class GetDocumentsResponse<T>
{
    [JsonPropertyName("results")]
    public List<T> Results { get; set; }

    [JsonPropertyName("offset")]
    public int Offest { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}