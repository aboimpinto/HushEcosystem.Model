using HushEcosystem.Model.Rpc.Transactions;

namespace HushEcosystem.Model.GlobalEvents;

public class TransactionsWithAddressRequestedEvent
{
    public string ChannelId { get; } = string.Empty;

    public TransactionsWithAddressRequest TransationsWithAddressRequest { get; }

    public TransactionsWithAddressRequestedEvent(string channerId, TransactionsWithAddressRequest transationsWithAddressRequest)
    {
        this.ChannelId = channerId;
        this.TransationsWithAddressRequest = transationsWithAddressRequest;
    }
}
