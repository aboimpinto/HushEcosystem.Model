using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Blockchain;

public class BlockchainHeightRequest : CommandRequestBase
{
    public static string CommandCode = "0ac82128-9c9e-4089-aeaa-6db63b3aef22";

    public BlockchainHeightRequest()
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
