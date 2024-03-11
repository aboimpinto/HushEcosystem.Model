using System.Text.Json;

namespace HushEcosystem.Model.Rpc;

public abstract class RpcRequestBase
{
    public string RPCMethodId { get; set; } = string.Empty;

     public abstract string ToJson(JsonSerializerOptions options);
}
