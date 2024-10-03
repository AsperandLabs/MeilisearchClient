using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class GetAllIndexesResponse
{
    [JsonPropertyName("results")]
    public List<MeilisearchIndex> Indices { get; set; }

    [JsonPropertyName("offset")]
    public int Offset { get; set; }
    
    [JsonPropertyName("limit")]
    public int Limit { get; set; }
    
    [JsonPropertyName("total")]
    public int TotalIndices { get; set; }
}