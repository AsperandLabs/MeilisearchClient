using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Requests;

public class GetDocumentsRequest
{
    [JsonPropertyName("limit")] 
    public int Limit { get; set; } = 20;

    [JsonPropertyName("offset")] 
    public int Offset { get; set; } = 0;

    [JsonPropertyName("fields")]
    public List<string>? FieldsToFetch { get; set; }

    [JsonPropertyName("retrieveVectors")] 
    public bool RetrieveVectors { get; set; } = false;
}