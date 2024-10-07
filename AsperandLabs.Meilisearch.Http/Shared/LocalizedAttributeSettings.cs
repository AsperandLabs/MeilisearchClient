using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Shared;

public class LocalizedAttributeSettings
{
    [JsonPropertyName("locale")]
    public List<string> Locales { get; set; }

    [JsonPropertyName("attributePatterns")]
    public List<string> AttributePatterns { get; set; }
}