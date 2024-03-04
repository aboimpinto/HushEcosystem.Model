using System.Collections.Generic;
using System.Text.Json;
using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Transactions;

public class TransactionsWithAddressResponse : CommandResponseBase
{
    public static string CommandCode = "44df817d-d52b-439d-b776-273250dd5207";

    public IList<VerifiedTransaction>? Transactions { get; set; }

    public double BlockHeightSyncPoint { get; set; }

    public TransactionsWithAddressResponse()
    {
        this.Command = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
