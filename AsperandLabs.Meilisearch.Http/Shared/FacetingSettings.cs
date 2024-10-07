using System.Text.Json;
using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Shared;

public class FacetingSettings
{
    [JsonPropertyName("maxValuesPerFacet")]
    public int MaxValuesPerFacet { get; set; }
    
    [JsonPropertyName("sortFacetValuesBy")]
    public Dictionary<string, string> SortFacetValuesBy { get; set; }

    public static FacetingSettings Default => new()
    {
        MaxValuesPerFacet = 100,
        SortFacetValuesBy = new Dictionary<string, string>
        {
            ["*"] = "alpha"
        }
    };
}