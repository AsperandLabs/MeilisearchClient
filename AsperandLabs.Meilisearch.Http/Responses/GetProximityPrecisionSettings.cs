using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class GetProximityPrecisionSettings
{
    [JsonPropertyName("proximityPrecision")]
    public string ProximityPrecision { get; set; }
}