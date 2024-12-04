using System.Text.Json.Serialization;

namespace LibraryManagerApi.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum GenderEnum
{
    Fiction,
    Romance,
    Fantasy,
    Adventure,
    Drama
}
