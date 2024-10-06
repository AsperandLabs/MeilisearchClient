using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

public class DumpCreation
{
    [JsonPropertyName("dumpUid")]
    public int? DumpId { get; set; }
}