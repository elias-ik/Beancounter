namespace Beancounter.Extension;

public static class GuidExtension
{
    public static string ToBase64String(this Guid guid)
    {
        return Convert.ToBase64String(guid.ToByteArray());
    }
    public static string ToPlainString(this Guid guid)
    {
        return guid.ToString("N");
    }
}