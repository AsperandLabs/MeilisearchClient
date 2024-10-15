using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class HealthResponse
{
    [JsonPropertyName("status")]
    public string Status { get; set; }
}