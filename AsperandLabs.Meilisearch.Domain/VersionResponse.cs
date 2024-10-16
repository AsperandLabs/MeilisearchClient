using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Domain;

public class VersionResponse
{
    [JsonPropertyName("commitSha")]
    public string CommitSha { get; set; }
    
    [JsonPropertyName("commitDate")]
    public DateTime CommitDate { get; set; }
    
    [JsonPropertyName("pkgVersion")]
    public string PackageVersion { get; set; }
}