using HushEcosystem.Model.Rpc.Handshake;

namespace HushEcosystem.Model.GlobalEvents;

public class HandshakeRequestedEvent
{
    public string ChannelId { get; } = string.Empty;

    public HandshakeRequest HandshakeRequest { get; }

    public HandshakeRequestedEvent(string channerId, HandshakeRequest handShakeRequest)
    {
        this.ChannelId = channerId;
        this.HandshakeRequest = handShakeRequest;
    }
}