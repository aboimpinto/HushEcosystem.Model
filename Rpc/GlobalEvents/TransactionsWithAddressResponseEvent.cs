using HushEcosystem.Model.Rpc.Transactions;

namespace HushEcosystem.Model.Rpc.GlobalEvents;

public class TransactionsWithAddressResponseEvent
{
    public string ChannelId { get; } = string.Empty;

    public TransactionsWithAddressResponse TransactionsWithAddressResponse { get; }

    public TransactionsWithAddressResponseEvent(string channerId, TransactionsWithAddressResponse transactionsWithAddressResponse)
    {
        this.ChannelId = channerId;
        this.TransactionsWithAddressResponse = transactionsWithAddressResponse;
    }
}
