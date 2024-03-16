using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Feeds;

public class FeedMessagesForAddressRequest : RpcRequestBase
{
    public static string CommandCode = "bbd3361d-30a8-4d75-bfb2-00575bfd258f";

    public string Address { get; set; } = string.Empty;

    public double SinceBlockIndex { get; set; }

    public FeedMessagesForAddressRequest()
    {
        this.RPCMethodId = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
