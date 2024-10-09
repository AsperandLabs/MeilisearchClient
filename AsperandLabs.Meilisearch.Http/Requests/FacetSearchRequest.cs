using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Requests;

public class FacetSearchRequest
{
    [JsonPropertyName("facetName")]
    public string? FacetName { get; set; }
    
    [JsonPropertyName("facetQuery")]
    public string? FacetQuery { get; set; }
    
    [JsonPropertyName("q")]
    public string QueryString { get; set; } = string.Empty;
    
    [JsonPropertyName("filter")]
    public string? SearchFilter { get; set; }

    [JsonPropertyName("matchingStrategy")] 
    public string MatchingStrategy { get; set; } = "last";
    
    [JsonPropertyName("attributesToSearchOn")]
    public List<string>? AttributesToSearchOn { get; set; }
}