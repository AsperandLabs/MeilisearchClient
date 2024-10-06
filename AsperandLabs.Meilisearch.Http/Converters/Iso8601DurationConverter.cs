using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace AsperandLabs.Meilisearch.Http.Converters;

public class Iso8601DurationConverter : JsonConverter<TimeSpan>
{
    public override TimeSpan Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    {
        return XmlConvert.ToTimeSpan(reader.GetString());
    }

    public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(XmlConvert.ToString(value));
    }
}