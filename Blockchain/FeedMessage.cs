using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public class FeedMessage : TransactionBase
{
    public static string TypeCode = "b6d58f59-c736-4c10-8e76-246e5c1181d0";

    public string FeedMessageId { get; set; } = string.Empty;

    public string FeedId { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
