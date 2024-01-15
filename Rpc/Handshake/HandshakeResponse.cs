using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Handshake;

public class HandshakeResponse : CommandResponseBase
{
    public static string CommandCode = "HandshakeResponse";

    // public bool Result { get; set; }

    // public string FailureReason { get; set; } = string.Empty;

    public HandshakeResponse()
    {
        this.Command = CommandCode;
    }

    public override string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }
}
