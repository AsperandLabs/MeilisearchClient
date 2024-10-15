using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class SimilarDocumentsResponse<TResult, TKey>
{
    [JsonPropertyName("hits")]
    public List<TResult> Results { get; set; }

    [JsonPropertyName("id")]
    public TKey Id { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }
    
    [JsonPropertyName("offset")]
    public int Offset { get; set; }
    
    [JsonPropertyName("processingTimeMs")]
    public int ProcessingTimeMilliseconds { get; set; }
    
    [JsonPropertyName("estimatedTotalHits")]
    public int EstimatedTotalHits { get; set; }
}