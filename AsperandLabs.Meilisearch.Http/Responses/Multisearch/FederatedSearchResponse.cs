using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.Multisearch;

public class FederatedSearchResponse
{
    [JsonPropertyName("hits")]
    public List<FederatedSearchResult> Results { get; set; }

    [JsonPropertyName("ProcessingTimeMs")]
    public int ProcessingTimeMilliseconds { get; set; }
    
    [JsonPropertyName("limit")]
    public int Limit { get; set; }
    
    [JsonPropertyName("offset")]
    public int Offset { get; set; }
    
    [JsonPropertyName("estimatedTotalHits")]
    public int EstimatedTotalHits { get; set; }
    
    [JsonPropertyName("semanticHitCount")]
    public int SemanticHitCount { get; set; }
}