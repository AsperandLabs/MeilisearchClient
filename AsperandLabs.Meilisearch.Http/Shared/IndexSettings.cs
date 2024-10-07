using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Shared;

public class IndexSettings
{
    [JsonPropertyName("dictionary")]
    public List<string> Dictionary { get; set; }
    
    [JsonPropertyName("displayedAttributes")]
    public List<string> DisplayedAttributes { get; set; }
    
    [JsonPropertyName("distinctAttribute")]
    public string? DistinctAttribute { get; set; }
    
    [JsonPropertyName("faceting")]
    public FacetingSettings Faceting { get; set; }
    
    [JsonPropertyName("filterableAttributes")]
    public List<string> FilterableAttributes { get; set; }
    
    [JsonPropertyName("pagination")]
    public PaginationSettings Pagination { get; set; }
    
    [JsonPropertyName("proximityPrecision")]
    public string ProximityPrecision { get; set; }
    
    [JsonPropertyName("rankingRules")]
    public List<string> RankingRules { get; set; }
    
    [JsonPropertyName("searchableAttributes")]
    public List<string> SearchableAttributes { get; set; }
    
    [JsonPropertyName("searchCutoffMs")]
    public int SearchCutOffMilliseconds { get; set; }
    
    [JsonPropertyName("separatorTokens")]
    public List<string> SeparatorTokens { get; set; }

    [JsonPropertyName("nonSeparatorTokens")]
    public List<string> NonSeparatorTokens { get; set; }

    [JsonPropertyName("sortableAttributes")]
    public List<string> SortableAttributes { get; set; }
    
    [JsonPropertyName("stopWords")]
    public List<string> StopWords { get; set; }
    
    [JsonPropertyName("synonyms")]
    //TODO: Find this object and implement it
    public object Synonyms { get; set; }
    
    [JsonPropertyName("typoTolerance")]
    public TypoToleranceSettings TypoTolerance { get; set; }
    
    [JsonPropertyName("embedders")]
    public Dictionary<string, EmbeddersSettings> Embedders { get; set; }
}