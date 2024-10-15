using System.Text.Json;

namespace AsperandLabs.Meilisearch.Http.Responses.Multisearch;

public class FederatedSearchResult
{
    public FederatedSearchResult(JsonElement json)
    {
        _valueJson = json;
        FederationDetails = json
            .GetProperty("_federation")
            .Deserialize<FederationDetails>()!;
    }

    private readonly JsonElement _valueJson;
    public FederationDetails FederationDetails { get; }
    public T? ReadAs<T>() => _valueJson.Deserialize<T>();
}