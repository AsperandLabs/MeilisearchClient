using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Requests.Multisearch;

public class FederationOptions
{
    [JsonPropertyName("weight")]
    public float Weight { get; set; }
}