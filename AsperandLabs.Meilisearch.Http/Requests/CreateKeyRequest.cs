using System.Text.Json.Serialization;
using AsperandLabs.Meilisearch.Http.Constants;

namespace AsperandLabs.Meilisearch.Http.Requests;

public class CreateKeyRequest
{
    [JsonPropertyName("actions")] 
    public List<string> Actions { get; set; } = Defaults.AllAttributes;
    
    [JsonPropertyName("indexes")]
    public List<string> Indicies { get; set; } = Defaults.AllAttributes;
    
    [JsonPropertyName("expiresAt")]
    public DateTime? ExpiresAt { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    
    [JsonPropertyName("uid")]
    public Guid? Id { get; set; }
}