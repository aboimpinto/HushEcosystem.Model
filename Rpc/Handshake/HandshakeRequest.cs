using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Handshake;

public class HandshakeRequest : RpcRequestBase
{
    public static string CommandCode = "e06a8bb3-71d3-47d6-9bdd-c6a8135ed977";

    public ClientType ClientType { get; set; }

    public string NodeId { get; set; } = string.Empty;

    public string NodeResonsabileAddress { get; set; } = string.Empty;

    public HandshakeRequest()
    {
        this.RPCMethodId = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
