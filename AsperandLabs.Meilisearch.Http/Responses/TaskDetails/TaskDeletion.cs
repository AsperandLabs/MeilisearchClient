
using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

public class TaskDeletion
{
    [JsonPropertyName("matchedTasks")]
    public int MatchedTasks { get; set; }
    [JsonPropertyName("deletedTasks")]
    public int? DeletedTasks { get; set; }
    [JsonPropertyName("originalFilter")]
    public string OriginalFilter { get; set; }
}