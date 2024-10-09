using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using AsperandLabs.Meilisearch.Http.Enums;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class MeilisearchTask
{
    [JsonPropertyName("taskUid")]
    public int Id { get; set; }

    [JsonPropertyName("indexUid")]
    public string? IndexId { get; set; }

    [JsonPropertyName("status")]
    public MeilisearchTaskStatus Status { get; set; }

    [JsonPropertyName("type")]
    public MeilisearchTaskType Type { get; set; }

    [JsonPropertyName("canceledBy")]
    public string? CanceledBy { get; set; }

    [JsonPropertyName("details")]
    internal JsonNode? Details { get; set; }

    [JsonPropertyName("error")]
    public MeilisearchError? Error { get; set; }

    [JsonPropertyName("duration")]
    public TimeSpan? ProcessingTime { get; set; }

    [JsonPropertyName("enqueuedAt")]
    public DateTime EnqueuedAt { get; set; }

    [JsonPropertyName("startedAt")]
    public DateTime? StartedAt { get; set; }

    [JsonPropertyName("finishedAt")]
    public DateTime? FinishedAt { get; set; }
}