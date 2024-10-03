using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class MeilisearchIndex
{
    [JsonPropertyName("uid")]
    public string Id { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedDateTime { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedDateTime { get; set; }

    [JsonPropertyName("primaryKey")]
    public string PrimaryKey { get; set; }
}