using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Blockchain;

public class BlockchainHeightResponse : CommandResponseBase
{
    public static string CommandCode = "4b7bc14a-013f-41fe-90ef-f51c12499b6b";

    public double Height { get; set; }

    public BlockchainHeightResponse()
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
