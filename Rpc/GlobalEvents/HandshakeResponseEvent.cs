using HushEcosystem.Model.Rpc.Handshake;

namespace HushEcosystem.Model.Rpc.GlobalEvents;

public class HandshakeResponseEvent
{
    public string ChannelId { get; } = string.Empty;

    public HandshakeResponse HandshakeResponse { get; }

    public HandshakeResponseEvent(string channerId, HandshakeResponse handshakeResponse)
    {
        this.ChannelId = channerId;
        this.HandshakeResponse = handshakeResponse;
    }
}