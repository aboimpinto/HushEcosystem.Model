using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Handshake;

public class HandshakeRequest : CommandRequestBase
{
    public static string CommandCode = "HandshakeRequest";

    public ClientType ClientType { get; set; }

    public string NodeId { get; set; } = string.Empty;

    public string NodeResonsabileAddress { get; set; } = string.Empty;

    public HandshakeRequest()
    {
        this.Command = CommandCode;
    }

    public override string ToJson()
    {
        return JsonSerializer.Serialize(this);
    }
}
