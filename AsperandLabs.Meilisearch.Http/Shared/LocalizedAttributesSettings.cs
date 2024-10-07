using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Shared;

public class LocalizedAttributesSettings
{
    [JsonPropertyName("localizedAttributes")]
    public List<LocalizedAttributeSettings> LocalizedAttributes { get; set; }
}