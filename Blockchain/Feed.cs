using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public class Feed : TransactionBase
{
    public static string TypeCode = "61791ba0-ef29-439a-8fcc-5c3d4c73d101";

    public string FeedId { get; set; } = string.Empty;

    public FeedTypeEnum FeedType { get; set; }

    public string FeedPublicEncriptAddress { get; set; } = string.Empty;

    public string FeedPrivateEncriptAddress { get; set; } = string.Empty;

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
