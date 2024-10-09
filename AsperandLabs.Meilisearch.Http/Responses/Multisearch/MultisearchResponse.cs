using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class MultisearchResponse<T>
{
    [JsonPropertyName("results")]
    public List<MultisearchResult<T>> Results { get; set; }
}