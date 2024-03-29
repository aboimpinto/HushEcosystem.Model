using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Handshake;

public class HandshakeResponse : RpcResponseBase
{
    public static string CommandCode = "491d5b17-b435-472f-abc8-162d40e1aea2";

    public HandshakeResponse()
    {
        this.RPCMethodId = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
