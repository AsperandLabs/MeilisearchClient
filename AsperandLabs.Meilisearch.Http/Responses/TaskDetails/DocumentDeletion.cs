using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

public class DocumentDeletion
{
    [JsonPropertyName("providedIds")]
    public List<string> ProvidedIds { get; set; }
    [JsonPropertyName("originalFilter")]
    public string? OriginalFilter { get; set; }
    [JsonPropertyName("deletedDocuments")]
    public int? DeletedDocmunts { get; set; }
}