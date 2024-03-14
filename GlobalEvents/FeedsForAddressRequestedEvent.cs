using HushEcosystem.Model.Rpc.Feeds;

namespace HushEcosystem.Model.GlobalEvents;

public class FeedsForAddressRequestedEvent
{
    public string ChannelId { get; } = string.Empty;

    public FeedsForAddressRequest FeedsForAddressRequest { get; }

    public FeedsForAddressRequestedEvent(string channerId, FeedsForAddressRequest feedsForAddressRequest)
    {
        this.ChannelId = channerId;
        this.FeedsForAddressRequest = feedsForAddressRequest;
    }
}
