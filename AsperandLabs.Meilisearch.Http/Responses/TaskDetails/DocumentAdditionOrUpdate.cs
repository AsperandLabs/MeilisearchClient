using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses.TaskDetails;

public class DocumentAdditionOrUpdate
{
    [JsonPropertyName("receivedDocuments")]
    public int RecievedDocuments { get; set; }
    [JsonPropertyName("indexedDocuments")]
    public int? IndexedDocuments { get; set; }
}