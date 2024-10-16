using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class UpdateKeyResponse
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
}