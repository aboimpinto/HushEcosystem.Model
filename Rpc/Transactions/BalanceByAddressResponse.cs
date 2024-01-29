using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Transactions;

public class BalanceByAddressResponse : CommandResponseBase
{
    public static string CommandCode = "4dde6b83-9cb5-4211-8f7d-2015afbd1bd3";

    public double Balance { get; set; }

    public BalanceByAddressResponse()
    {
        this.Command = CommandCode;
    }

    public override string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }
}
