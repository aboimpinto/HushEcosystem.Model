using System.Text.Json;
using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Feeds;

public class NewFeedRequest : CommandRequestBase
{
    public static string CommandCode = "ba0dbdd2-842f-42ca-a2c4-3409f75a17b8";

    public Feed Feed { get; set; }

    public NewFeedRequest()
    {
        this.Command = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
