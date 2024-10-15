using System.Text.Json.Serialization;
using AsperandLabs.Meilisearch.Http.Constants;

namespace AsperandLabs.Meilisearch.Http.Requests;

public class SimilarDocumentsRequest<TKey>
{
    [JsonPropertyName("id")]
    public TKey Id { get; set; }

    [JsonPropertyName("embedder")]
    public string Embedder { get; set; } = Defaults.DefaultEmbedder;

    [JsonPropertyName("attributesToRetrieve")]
    public List<string> AttributesToRetrieve { get; set; } = Defaults.AllAttributes;

    [JsonPropertyName("offset")]
    public int Offset { get; set; }

    [JsonPropertyName("limit")]
    public int Limit { get; set; } = 20;

    [JsonPropertyName("filter")]
    public string Filter { get; set; }

    [JsonPropertyName("showRankingScore")]
    public bool ShowRankingScore { get; set; }

    [JsonPropertyName("showRankingScoreDetails")]
    public bool ShowRankingScoreDetails { get; set; }

    [JsonPropertyName("rankingScoreThreshold")]
    public float? RankingScoreThreshold { get; set; }

    [JsonPropertyName("retrieveVectors")]
    public bool RetrieveVectors { get; set; }
}