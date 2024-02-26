using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Feeds;

public class SendMessageRequest : CommandRequestBase
{
    public static string CommandCode = "f3e3e3e3-842f-42ca-a2c4-3409f75a17b8";

    public string FeedId { get; set; } = string.Empty;

    public string Message { get; set; } = string.Empty;

    public SendMessageRequest()
    {
        this.Command = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
