using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class FacetSearchResponse
{
    [JsonPropertyName("facetHits")]
    public List<FacetHits> Results { get; set; }

    [JsonPropertyName("facetQuery")]
    public string FacetQuery { get; set; }
    
    [JsonPropertyName("processingTimeMs")]
    public int ProcessingTime { get; set; }
}