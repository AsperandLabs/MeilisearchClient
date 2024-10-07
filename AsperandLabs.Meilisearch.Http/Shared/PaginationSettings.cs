using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Shared;

public class PaginationSettings
{
    [JsonPropertyName("maxTotalHits")]
    public int MaxTotalHits { get; set; }
    
    public static PaginationSettings Default { get; } = new()
    {
        MaxTotalHits = 1000
    };
}