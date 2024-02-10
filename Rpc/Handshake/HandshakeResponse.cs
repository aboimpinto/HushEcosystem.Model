using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Handshake;

public class HandshakeResponse : CommandResponseBase
{
    public static string CommandCode = "491d5b17-b435-472f-abc8-162d40e1aea2";

    public HandshakeResponse()
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
