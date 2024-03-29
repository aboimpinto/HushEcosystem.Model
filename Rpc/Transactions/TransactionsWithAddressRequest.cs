using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Transactions;

public class TransactionsWithAddressRequest : RpcRequestBase
{
    public static string CommandCode = "42507fc0-6b96-43a2-94a1-5ec8bf0fa5b5";

    public string Address { get; set; } = string.Empty;

    public double LastHeightSynched { get; set; }

    public TransactionsWithAddressRequest()
    {
        this.RPCMethodId = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}