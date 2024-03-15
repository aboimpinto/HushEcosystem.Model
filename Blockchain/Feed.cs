using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public class Feed : TransactionBase
{
    public string TypeCode = "57cb40d4-df4b-488d-bd3a-cf07add608dc";

    public string FeedId { get; set; } = string.Empty;

    public FeedTypeEnum FeedType { get; set; }

    public string FeedParticipantPublicAddress { get; set; } = string.Empty;

    public string FeedPublicEncriptAddress { get; set; } = string.Empty;

    public string FeedPrivateEncriptAddress { get; set; } = string.Empty;

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
