using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Transactions;

public class BalanceByAddressResponse : RpcResponseBase
{
    public static string CommandCode = "4dde6b83-9cb5-4211-8f7d-2015afbd1bd3";

    public double Balance { get; set; }

    public BalanceByAddressResponse()
    {
        this.RPCMethodId = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
