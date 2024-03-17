using HushEcosystem.Model.Rpc.Feeds;

namespace HushEcosystem.Model.GlobalEvents;

public class FeedMessagesForAddressRequestedEvent
{
    public string ChannelId { get; } = string.Empty;

    public FeedMessagesForAddressRequest FeedMessagesForAddressRequest { get; }

    public FeedMessagesForAddressRequestedEvent(string channerId, FeedMessagesForAddressRequest feedMessagesForAddressRequest)
    {
        this.ChannelId = channerId;
        this.FeedMessagesForAddressRequest = feedMessagesForAddressRequest;
    }
}
