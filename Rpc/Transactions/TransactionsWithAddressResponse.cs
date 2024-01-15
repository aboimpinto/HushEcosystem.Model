using System.Collections.ObjectModel;
using System.Text.Json;
using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Transactions;

public class TransactionsWithAddressResponse : CommandResponseBase
{
    public static string CommandCode = "TransactionsWithAddressResponse";

    public ReadOnlyCollection<TransactionBase> Transactions { get; set; }

    public TransactionsWithAddressResponse()
    {
        this.Command = CommandCode;
    }

    public override string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }
}
