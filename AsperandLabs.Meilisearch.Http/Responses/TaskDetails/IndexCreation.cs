using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

public class IndexCreation
{
    [JsonPropertyName("primaryKey")]
    public string? PrimaryKey { get; set; }
}