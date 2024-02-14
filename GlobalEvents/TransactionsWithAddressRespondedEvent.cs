using HushEcosystem.Model.Rpc.Transactions;

namespace HushEcosystem.Model.GlobalEvents;

public class TransactionsWithAddressRespondedEvent
{
    public string ChannelId { get; } = string.Empty;

    public TransactionsWithAddressResponse TransactionsWithAddressResponse { get; }

    public TransactionsWithAddressRespondedEvent(string channerId, TransactionsWithAddressResponse transactionsWithAddressResponse)
    {
        this.ChannelId = channerId;
        this.TransactionsWithAddressResponse = transactionsWithAddressResponse;
    }
}
