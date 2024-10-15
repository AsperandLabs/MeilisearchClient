using System.Text.Json;
using System.Text.Json.Serialization;
using AsperandLabs.Meilisearch.Http.Responses.Multisearch;

namespace AsperandLabs.Meilisearch.Http.Converters;

public class FederatedSearchResultConverter : JsonConverter<FederatedSearchResult>
{
    public override FederatedSearchResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        return new FederatedSearchResult(doc.RootElement);
    }

    public override void Write(Utf8JsonWriter writer, FederatedSearchResult value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}