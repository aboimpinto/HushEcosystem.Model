using System.Text.Json;
using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Transactions;

public class TransactionsWithAddressResponse : CommandResponseBase
{
    public static string CommandCode = "44df817d-d52b-439d-b776-273250dd5207";

    public IList<VerifiedTransaction>? Transactions { get; set; }

    public TransactionsWithAddressResponse()
    {
        this.Command = CommandCode;
    }

    public override string ToJson(TransactionBaseConverter options)
    {
        var jsonOptions = new JsonSerializerOptions
        {
            Converters = { options }
        };

        return JsonSerializer.Serialize(this, jsonOptions);
    }
}
