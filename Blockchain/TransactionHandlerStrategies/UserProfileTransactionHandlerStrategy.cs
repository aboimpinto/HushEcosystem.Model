using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HushEcosystem.Model.GlobalEvents;
using Olimpo;

namespace HushEcosystem.Model.Blockchain.TransactionHandlerStrategies;

public class UserProfileTransactionHandlerStrategy
{
    private IEventAggregator _eventAggregator;

    public UserProfileTransactionHandlerStrategy(IEventAggregator eventAggregator)
    {
        this._eventAggregator = eventAggregator;
    }

    public bool CanHandle(TransactionBase transactionBase)
    {
        if (transactionBase is UserProfile)
        {
            return true;
        }

        return false;
    }

    public async Task Handle(TransactionBase transactionBase)
    {
        var transaction = transactionBase as UserProfile;

        if (transaction == null)
        {
            throw new InvalidOperationException("Invalid transaction type. At this point the transaction should be a UserProfile.");
        }

        await this._eventAggregator.PublishAsync(new UserProfileTransactionHandledEvent(transaction));
    }
}
