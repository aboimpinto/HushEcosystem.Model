using HushEcosystem.Model.Rpc.Feeds;

namespace HushEcosystem.Model.GlobalEvents;

public class FeedsForAddressRespondedEvent
{
    public string ChannelId { get; } = string.Empty;

    public FeedsForAddressResponse FeedsForAddressResponse { get; }

    public FeedsForAddressRespondedEvent(string channerId, FeedsForAddressResponse feedsForAddressResponse)
    {
        this.ChannelId = channerId;
        this.FeedsForAddressResponse = feedsForAddressResponse;
    }
}
