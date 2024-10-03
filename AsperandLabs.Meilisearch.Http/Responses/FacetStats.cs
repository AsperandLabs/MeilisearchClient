using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class FacetStats
{
    [JsonPropertyName("rating")]
    public (int Min, int Max) Rating { get; set; }
}

class FacetRating 
{
    [JsonPropertyName("min")]
    public int Min { get; set; }
    
    [JsonPropertyName("max")]
    public int Max { get; set; }
}

