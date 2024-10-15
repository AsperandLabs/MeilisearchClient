using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.Multisearch;

public class FederationDetails
{
    [JsonPropertyName("indexUid")]
    public string IndexId { get; set; }
    
    [JsonPropertyName("queriesPosition")] 
    public int QueryPosition { get; set; }
}