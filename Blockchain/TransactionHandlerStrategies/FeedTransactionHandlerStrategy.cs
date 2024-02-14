using HushEcosystem.Model.GlobalEvents;
using Olimpo;

namespace HushEcosystem.Model.Blockchain.TransactionHandlerStrategies;

public class FeedTransactionHandlerStrategy : ITransactionHandlerStrategy
{
    private IEventAggregator _eventAggregator;

    public FeedTransactionHandlerStrategy(IEventAggregator eventAggregator)
    {
        this._eventAggregator = eventAggregator;
    }

    public bool CanHandle(TransactionBase transactionBase)
    {
        if (transactionBase is Feed)
        {
            return true;
        }

        return false;
    }

    public async Task Handle(TransactionBase transactionBase)
    {
        var feed = transactionBase as Feed;

        if (feed == null)
        {
            throw new InvalidOperationException("Invalid transaction type. At this point the transaction should be a Feed.");
        }

        await this._eventAggregator.PublishAsync(new FeedTransactionHandledEvent(feed));
    }
}
