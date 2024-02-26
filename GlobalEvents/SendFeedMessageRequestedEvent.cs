using HushEcosystem.Model.Rpc.Feeds;

namespace HushEcosystem.Model.GlobalEvents;

public class SendFeedMessageRequestedEvent
{
    public string ChannelId { get; } = string.Empty;

    public SendFeedMessageRequest SendMessageRequest { get; }

    public SendFeedMessageRequestedEvent(string channerId, SendFeedMessageRequest request)
    {
        this.ChannelId = channerId;
        this.SendMessageRequest = request;
    }    
}
