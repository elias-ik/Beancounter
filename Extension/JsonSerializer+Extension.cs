using Newtonsoft.Json;

namespace Beancounter.Extension;

public static class JsonSerializerExtension
{
    public static string Serialize(this JsonSerializer jsonSerializer, object obj)
    {
        string? jsonString = null;
        using var stringWriter = new StringWriter();
        jsonSerializer.Serialize(stringWriter, obj);
        jsonString = stringWriter.ToString();
        return jsonString;
    }
}