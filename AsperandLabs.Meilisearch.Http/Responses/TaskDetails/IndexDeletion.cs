using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

public class IndexDeletion
{
    [JsonPropertyName("deletedDocuments")]
    public int? DeletedDocumentsCount { get; set; }
}