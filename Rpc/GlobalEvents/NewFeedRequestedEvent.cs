using HushEcosystem.Model.Rpc.Feeds;

namespace HushEcosystem.Model.Rpc.GlobalEvents;

public class NewFeedRequestedEvent
{
    public string ChannelId { get; } = string.Empty;

    public NewFeedRequest NewFeedRequest { get; }

    public NewFeedRequestedEvent(string channerId, NewFeedRequest request)
    {
        this.ChannelId = channerId;
        this.NewFeedRequest = request;
    }
}