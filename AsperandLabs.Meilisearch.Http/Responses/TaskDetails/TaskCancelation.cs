using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

public class TaskCancelation
{
    [JsonPropertyName("matchedTasks")]
    public int MatchedTasks { get; set; }
    [JsonPropertyName("canceledTasks")]
    public int? CanceledTasks { get; set; }
    [JsonPropertyName("originalFilter")]
    public string OriginalFilter { get; set; }
}