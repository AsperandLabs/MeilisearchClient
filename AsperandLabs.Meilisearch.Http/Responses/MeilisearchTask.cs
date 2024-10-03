using System.Text.Json.Serialization;
using AsperandLabs.Meilisearch.Http.Enums;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class MeilisearchTask
{
    [JsonPropertyName("taskUid")]
    public int Id { get; set; }

    [JsonPropertyName("indexUid")]
    public string IndexId { get; set; }

    [JsonPropertyName("status")]
    public MeilisearchTaskStatus Status { get; set; }

    [JsonPropertyName("type")]
    public MeilisearchTaskType Type { get; set; }

    [JsonPropertyName("enqueuedAt")]
    public DateTime EnqueueDateTime { get; set; }
}