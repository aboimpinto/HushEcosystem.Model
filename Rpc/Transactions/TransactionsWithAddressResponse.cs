using System.Text.Json;
using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Transactions;

public class TransactionsWithAddressResponse : CommandResponseBase
{
    public static string CommandCode = "44df817d-d52b-439d-b776-273250dd5207";

    public IList<TransactionBase> Transactions { get; set; }

    public TransactionsWithAddressResponse()
    {
        this.Command = CommandCode;
    }

    public override string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }
}
