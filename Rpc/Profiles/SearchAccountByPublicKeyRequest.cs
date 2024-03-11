using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Profiles;

public class SearchAccountByPublicKeyRequest : RpcRequestBase
{
    public static string CommandCode = "c4906520-a72b-4bca-a8f4-44de5e6f69bb";

    public string UserPublicKey { get; set; } = string.Empty;

    public SearchAccountByPublicKeyRequest()
    {
        this.RPCMethodId = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
