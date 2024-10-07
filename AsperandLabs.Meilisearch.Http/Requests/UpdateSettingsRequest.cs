using System.Text.Json.Serialization;
using AsperandLabs.Meilisearch.Http.Clients.Constants;
using AsperandLabs.Meilisearch.Http.Shared;

namespace AsperandLabs.Meilisearch.Http.Requests;

public class UpdateSettingsRequest
{
    
    [JsonPropertyName("dictionary")]
    public List<string> Dictionary { get; set; } = [];
    
    [JsonPropertyName("displayedAttributes")]
    public List<string> DisplayedAttributes { get; set; } = Defaults.AllAttributes;
    
    [JsonPropertyName("distinctAttribute")]
    public string? DistinctAttribute { get; set; } = null;
    
    [JsonPropertyName("faceting")]
    public FacetingSettings Faceting { get; set; } = FacetingSettings.Default;
    
    [JsonPropertyName("filterableAttributes")]
    public List<string> FilterableAttributes { get; set; } = [];
    
    [JsonPropertyName("pagination")]
    public PaginationSettings Pagination { get; set; } = PaginationSettings.Default;
    
    [JsonPropertyName("proximityPrecision")]
    public string ProximityPrecision { get; set; } = Defaults.ProximityPrecision;
    
    [JsonPropertyName("rankingRules")]
    public List<string> RankingRules { get; set; } = Defaults.RankingRules;
    
    [JsonPropertyName("searchableAttributes")]
    public List<string> SearchableAttributes { get; set; } = Defaults.AllAttributes;
    
    [JsonPropertyName("searchCutoffMs")]
    public int SearchCutOffMilliseconds { get; set; } = 1500;
    
    [JsonPropertyName("separatorTokens")]
    public List<string> SeparatorTokens { get; set; } = [];
    
    [JsonPropertyName("nonSeparatorTokens")]
    public List<string> NonSeparatorTokens { get; set; } = [];
    
    [JsonPropertyName("sortableAttributes")]
    public List<string> SortableAttributes { get; set; } = [];
    
    [JsonPropertyName("stopWords")]
    public List<string> StopWords { get; set; } = [];
    
    [JsonPropertyName("synonyms")]
    //TODO: Find this object and implement it
    public object Synonyms { get; set; } = new();
    
    [JsonPropertyName("typoTolerance")]
    public TypoToleranceSettings TypeTolerance { get; set; } = TypoToleranceSettings.Default;
    
    [JsonPropertyName("embedders")]
    public Dictionary<string, EmbeddersSettings> Embedders { get; set; }
}