using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

public class SettingsUpdate
{
    [JsonPropertyName("rankingRules")]
    public List<string> RankingRules { get; set; }
    [JsonPropertyName("filterableAttributes")]
    public List<string> FilterableAttributes { get; set; }
    [JsonPropertyName("distinctAttribute")]
    public string DistinctAttribute { get; set; }
    [JsonPropertyName("searchableAttributes")]
    public List<string> SearchableAttributes { get; set; }
    [JsonPropertyName("displayedAttributes")]
    public List<string> DisplayedAttributes { get; set; }
    [JsonPropertyName("sortableAttributes")]
    public List<string> SortableAttributes { get; set; }
    [JsonPropertyName("stopWords")]
    public List<string> StopWords { get; set; }
    [JsonPropertyName("synonyms")]
    public List<string> Synonyms { get; set; }
    [JsonPropertyName("typoTolerance")]
    //TODO: Find and create the object for these
    public object TypoTolerance { get; set; }
    [JsonPropertyName("pagination")]
    public object Pagination { get; set; }
    [JsonPropertyName("faceting")]
    public object Faceting { get; set; }
}