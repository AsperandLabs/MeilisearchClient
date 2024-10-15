using System.Text.Json.Serialization;

namespace AsperandLabs.Meilisearch.Http.Responses;

public class VersionResponse
{
    [JsonPropertyName("commitSha")]
    public string CommitSha { get; set; }
    
    [JsonPropertyName("commitDate")]
    public DateTime CommitDate { get; set; }
    
    [JsonPropertyName("pkgVersion")]
    public string PackageVersion { get; set; }
}