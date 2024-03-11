using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Transactions;

public class BalanceByAddressRequest : RpcRequestBase
{
    public static string CommandCode = "84a1d2e9-3093-4a96-92cc-0e362fb03ab7";

    public string Address { get; set; } = string.Empty;

    public BalanceByAddressRequest()
    {
        this.RPCMethodId = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
