using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Shared;

public class EmbeddersSettings
{
    [JsonPropertyName("source")]
    public string Source { get; set; }
    
    [JsonPropertyName("url")]
    public string Url { get; set; }
    
    [JsonPropertyName("apiKey")]
    public string ApiKey { get; set; }
    
    [JsonPropertyName("model")]
    public string Model { get; set; }
    
    [JsonPropertyName("documentTemplate")]
    public string DocumentTemplate { get; set; }
    
    [JsonPropertyName("dimensions")]
    public int Dimensions { get; set; }
    
    [JsonPropertyName("revision")]
    public string Revision { get; set; }
    
    //TODO: Find these types and implement them
    [JsonPropertyName("distribution")]
    public object Distribution { get; set; }
    
    [JsonPropertyName("request")]
    public object Request { get; set; }
    
    [JsonPropertyName("response")]
    public object Response { get; set; }
}