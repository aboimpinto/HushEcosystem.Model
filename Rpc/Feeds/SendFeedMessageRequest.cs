using System.Text.Json;
using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Feeds;

public class SendFeedMessageRequest : CommandRequestBase
{
    public static string CommandCode = "f3e3e3e3-842f-42ca-a2c4-3409f75a17b8";

    public FeedMessage FeedMessage { get; set; }

    public SendFeedMessageRequest()
    {
        this.Command = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
