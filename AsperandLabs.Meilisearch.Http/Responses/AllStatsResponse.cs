using System.Text.Json.Serialization;
using AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class AllStatsResponse
{
    [JsonPropertyName("databaseSize")]
    public long DatabaseSizeBytes { get; set; }
    
    [JsonPropertyName("lastUpdate")]
    public DateTime LastUpdateDate { get; set; }
    
    [JsonPropertyName("indexes")]
    public Dictionary<string, IndexStats> IndexStats { get; set; }
}