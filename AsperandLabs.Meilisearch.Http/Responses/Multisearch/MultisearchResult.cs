using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class MultisearchResult<T>
{
    [JsonPropertyName("indexUid")]
    public string IndexId { get; set; }

    [JsonPropertyName("hits")]
    public List<T> Hits { get; set; }

    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; }

    [JsonPropertyName("estimatedTotalHits")]
    public int EstimatedTotalHits { get; set; }

    [JsonPropertyName("totalHits")]
    public int TotalHits { get; set; }

    [JsonPropertyName("totalPages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("hitsPerPage")]
    public int HitsPerPage { get; set; }

    [JsonPropertyName("page")]
    public int Page { get; set; }
    
    [JsonPropertyName("facetDistribution")]
    public Dictionary<string, Dictionary<string, int>> FacetDistribution { get; set; }

    [JsonPropertyName("facetStats")]
    public FacetStats FacetStats { get; set; }

    [JsonPropertyName("processingTimeMs")]
    public int ProcessingTimeMilliseconds { get; set; }

    [JsonPropertyName("query")]
    public string Query { get; set; }
}