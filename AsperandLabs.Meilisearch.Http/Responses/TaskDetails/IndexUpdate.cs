using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

public class IndexUpdate
{
    [JsonPropertyName("primaryKey")]
    public string? PrimaryKey { get; set; }
}