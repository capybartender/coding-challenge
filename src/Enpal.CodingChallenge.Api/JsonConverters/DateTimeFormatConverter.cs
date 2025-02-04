using System.Text.Json;
using System.Text.Json.Serialization;

namespace Enpal.CodingChallenge.Api.JsonConverters;

public class DateTimeFormatConverter : JsonConverter<DateTime>
{
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (!reader.TryGetDateTime(out var value))
        {
            value = DateTime.Parse(reader.GetString()!);
        }

        return value;
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        var formattedDateTimeString = value.ToString("yyyy-MM-ddTHH:mm:ss.ffZ");
        writer.WriteStringValue(formattedDateTimeString);
    }
}