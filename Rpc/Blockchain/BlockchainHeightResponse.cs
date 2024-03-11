using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Blockchain;

public class BlockchainHeightResponse : RpcResponseBase
{
    public static string CommandCode = "4b7bc14a-013f-41fe-90ef-f51c12499b6b";

    public double Height { get; set; } = 0;

    public BlockchainHeightResponse()
    {
        this.RPCMethodId = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
