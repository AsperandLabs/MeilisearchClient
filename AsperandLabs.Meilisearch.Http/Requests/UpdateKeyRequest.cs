using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Requests;

public class UpdateKeyRequest
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
}