using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.GlobalEvents;

public class FeedMessageTransactionHandledEvent
{
    public FeedMessage FeedMessage { get; }    

    public FeedMessageTransactionHandledEvent(FeedMessage feedMessage)
    {
        this.FeedMessage = feedMessage;
    }
}
