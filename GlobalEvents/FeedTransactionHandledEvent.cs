using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.GlobalEvents;

public class FeedTransactionHandledEvent
{
    public Feed Feed { get; }    

    public FeedTransactionHandledEvent(Feed feed)
    {
        this.Feed = feed;
    }
}
