using HushEcosystem.Model.Rpc.Handshake;

namespace HushEcosystem.Model.GlobalEvents;

public class HandshakeRespondedEvent
{
    public string ChannelId { get; } = string.Empty;

    public HandshakeResponse HandshakeResponse { get; }

    public HandshakeRespondedEvent(string channerId, HandshakeResponse handshakeResponse)
    {
        this.ChannelId = channerId;
        this.HandshakeResponse = handshakeResponse;
    }
}