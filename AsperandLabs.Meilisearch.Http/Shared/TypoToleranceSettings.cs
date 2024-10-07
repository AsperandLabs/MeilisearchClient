using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Shared;

public class TypoToleranceSettings
{
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
    
    [JsonPropertyName("minWordSizeForTypos.oneTypo")]
    public int MinWordSizeForTypesOneTypo { get; set; }
    
    [JsonPropertyName("minWordSizeForTypos.twoTypos")]
    public int MinWordSizeForTypesTwoTypos { get; set; }
    
    [JsonPropertyName("disableOnWords")]
    public List<string> DisableOnWords { get; set; }
    
    [JsonPropertyName("disableOnAttributes")]
    public List<string> DisableOnAttributes { get; set; }

    public static TypoToleranceSettings Default => new()
    {
        Enabled = true,
        MinWordSizeForTypesTwoTypos = 9,
        MinWordSizeForTypesOneTypo = 5,
        DisableOnAttributes = [],
        DisableOnWords = []
    };
}