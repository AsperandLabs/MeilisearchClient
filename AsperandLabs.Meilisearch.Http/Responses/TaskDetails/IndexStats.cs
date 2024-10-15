using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

public class IndexStats
{
    [JsonPropertyName("numberOfDocuments")]
    public int DocumentCount { get; set; }
    
    [JsonPropertyName("isIndexing")]
    public bool IsIndexing { get; set; }
    
    [JsonPropertyName("fieldDistrubution")]
    public Dictionary<string, int> FieldDistribution { get; set; }
}