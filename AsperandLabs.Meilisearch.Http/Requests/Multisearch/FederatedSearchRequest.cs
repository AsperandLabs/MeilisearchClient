using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Requests.Multisearch;

public class FederatedSearchRequest
{
    [JsonPropertyName("federationOptions")]
    public FederationOptions FederationOptions { get; set; }
    
    [JsonPropertyName("indexUid")]
    public string IndexId { get; set; }
    
    [JsonPropertyName("q")]
    public string Query { get; set; }
    
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
    
    [JsonPropertyName("facets")]
    public List<string> Facets { get; set; }
    
    [JsonPropertyName("attributesToRetrieve")]
    public List<string> AttributesToRetrieve { get; set; }
    
    [JsonPropertyName("attributesToCrop")]
    public List<string> AttributesToCrop { get; set; }

    [JsonPropertyName("cropLength")]
    public int CropLength { get; set; }

    [JsonPropertyName("cropMarker")]
    public string CropMarker { get; set; }

    [JsonPropertyName("attributesToHighlight")]
    public List<string> AttributesToHighlight { get; set; }

    [JsonPropertyName("highlightPreTag")]
    public string HighlightPreTag { get; set; }

    [JsonPropertyName("highlightPostTag")]
    public string HighlightPostTag { get; set; }

    [JsonPropertyName("showMatchesPosition")]
    public bool ShowMatchesPosition { get; set; }

    [JsonPropertyName("sort")]
    public List<string> Sort { get; set; }

    [JsonPropertyName("matchingStrategy")]
    public string MatchingStrategy { get; set; }

    [JsonPropertyName("showRankingScore")]
    public bool ShowRankingScore { get; set; }

    [JsonPropertyName("attributesToSearchOn")]
    public int AttributesToSearchOn { get; set; }
}