using HushEcosystem.Model.Rpc.Transactions;

namespace HushEcosystem.Model.Rpc.GlobalEvents;

public class BalanceByAddressRespondedEvent
{
    public string ChannelId { get; } = string.Empty;

    public BalanceByAddressResponse BalanceByAddressResponse { get; }

    public BalanceByAddressRespondedEvent(string channerId, BalanceByAddressResponse balanceByAddressResponse)
    {
        this.ChannelId = channerId;
        this.BalanceByAddressResponse = balanceByAddressResponse;
    }
}
