using HushEcosystem.Model.GlobalEvents;
using Olimpo;

namespace HushEcosystem.Model.Blockchain.TransactionHandlerStrategies;

public class FeedMessageTransactionHandlerStrategy : ITransactionHandlerStrategy
{
    private IEventAggregator _eventAggregator;

    public FeedMessageTransactionHandlerStrategy(IEventAggregator eventAggregator)
    {
        this._eventAggregator = eventAggregator;
    }

    public bool CanHandle(TransactionBase transactionBase)
    {
        if (transactionBase is FeedMessage)
        {
            return true;
        }

        return false;
    }

    public async Task Handle(TransactionBase transactionBase)
    {
        var feedMessage = transactionBase as FeedMessage;

        if (feedMessage == null)
        {
            throw new InvalidOperationException("Invalid transaction type. At this point the transaction should be a FeedMessage.");
        }

        await this._eventAggregator.PublishAsync(new FeedMessageTransactionHandledEvent(feedMessage));
    }
}
