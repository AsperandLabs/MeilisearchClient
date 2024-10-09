using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class FacetHits
{
    [JsonPropertyName("value")]
    public string Value { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }
}