using HushEcosystem.Model.Rpc.Transactions;

namespace HushEcosystem.Model.Rpc.GlobalEvents;

public class TransationsWithAddressRequestedEvent
{
    public string ChannelId { get; } = string.Empty;

    public TransationsWithAddressRequest TransationsWithAddressRequest { get; }

    public TransationsWithAddressRequestedEvent(string channerId, TransationsWithAddressRequest transationsWithAddressRequest)
    {
        this.ChannelId = channerId;
        this.TransationsWithAddressRequest = transationsWithAddressRequest;
    }
}
