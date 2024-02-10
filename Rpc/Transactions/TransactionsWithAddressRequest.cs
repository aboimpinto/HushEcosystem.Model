using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Transactions;

public class TransactionsWithAddressRequest : CommandRequestBase
{
    public static string CommandCode = "42507fc0-6b96-43a2-94a1-5ec8bf0fa5b5";

    public string Address { get; set; } = string.Empty;

    public int LastHeightSynched { get; set; }

    public TransactionsWithAddressRequest()
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