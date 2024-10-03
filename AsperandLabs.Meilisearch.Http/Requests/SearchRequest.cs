using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Requests;

public class SearchRequest
{
    [JsonPropertyName("q")]
    public string Query { get; set; }
    
    [JsonPropertyName("offset")]
    public int Offset { get; set; }
    
    [JsonPropertyName("limit")]
    public int Limit { get; set; }
    
    [JsonPropertyName("hitsPerPage")]
    public int PageSize { get; set; }
    
    [JsonPropertyName("page")]
    public int Page { get; set; }
    
    [JsonPropertyName("filter")]
    public string Filter { get; set; }
    
    [JsonPropertyName("facets")]
    public List<string> Facets { get; set; }
    
    [JsonPropertyName("attributesToRetrieve")]
    public List<string> AttributesToRetrieve { get; set; }
    
    [JsonPropertyName("attributesToCrop")]
    public List<string> AttributesToCrop { get; set; }

    [JsonPropertyName("cropLength")]
    public int CropLength { get; set; }

    [JsonPropertyName("cropMarker")]
    public string CropMarker { get; set; }

    [JsonPropertyName("attributesToHighlight")]
    public List<string> AttributesToHighlight { get; set; }

    [JsonPropertyName("highlightPreTag")]
    public string HighlightPreTag { get; set; }

    [JsonPropertyName("highlightPostTag")]
    public string HighlightPostTag { get; set; }

    [JsonPropertyName("showMatchesPosition")]
    public bool ShowMatchesPosition { get; set; }

    [JsonPropertyName("sort")]
    public List<string> Sort { get; set; }

    [JsonPropertyName("matchingStrategy")]
    public string MatchingStrategy { get; set; }

    [JsonPropertyName("showRankingScore")]
    public bool ShowRankingScore { get; set; }
    
    [JsonPropertyName("showRankingDetails")]
    public bool ShowRankingDetails { get; set; }

    [JsonPropertyName("rankingScoreThreashold")]
    public int RankingScoreThreashold { get; set; }

    [JsonPropertyName("attributesToSearchOn")]
    public int AttributesToSearchOn { get; set; }

    [JsonPropertyName("hybrid")]
    public object Hybrid { get; set; }

    [JsonPropertyName("vector")]
    public List<int> Vector { get; set; }

    [JsonPropertyName("retrieveVectors")]
    public bool RetrieveVectors { get; set; }

    [JsonPropertyName("cropLength")]
    public List<string> Locales { get; set; }
}