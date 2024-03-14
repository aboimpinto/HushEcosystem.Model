using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Feeds;

public class FeedsForAddressRequest : RpcRequestBase
{
    public static string CommandCode = "c58558c5-5c0d-4f65-a4b6-c1b25737a07c";    

    public string Address { get; set; } = string.Empty;

    public double SinceBlockIndex { get; set; } = 0;

    public FeedsForAddressRequest()
    {
        this.RPCMethodId = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
