using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

public class IndexSwap
{
    [JsonPropertyName("swaps")]
    public List<string> Swaps { get; set; }
}