using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class MeilisearchKey
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    [JsonPropertyName("key")]
    public string Key { get; set; }
    
    [JsonPropertyName("uid")]
    public Guid Id { get; set; }
    
    [JsonPropertyName("actions")]
    public List<string> Actions { get; set; }
    
    [JsonPropertyName("indexes")]
    public List<string> Indicies { get; set; }
    
    [JsonPropertyName("expiresAt")]
    public DateTime ExpiresAt { get; set; }
    
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }
}