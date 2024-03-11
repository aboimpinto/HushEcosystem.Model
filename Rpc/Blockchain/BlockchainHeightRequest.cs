using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Blockchain;

public class BlockchainHeightRequest : RpcRequestBase
{
    public static string CommandCode = "0ac82128-9c9e-4089-aeaa-6db63b3aef22";

    public BlockchainHeightRequest()
    {
        this.RPCMethodId = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
