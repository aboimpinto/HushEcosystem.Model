using HushEcosystem.Model.Rpc.Transactions;

namespace HushEcosystem.Model.Rpc.GlobalEvents;

public class BalanceByAddressResponseEvent
{
    public string ChannelId { get; } = string.Empty;

    public BalanceByAddressResponse BalanceByAddressResponse { get; }

    public BalanceByAddressResponseEvent(string channerId, BalanceByAddressResponse balanceByAddressResponse)
    {
        this.ChannelId = channerId;
        this.BalanceByAddressResponse = balanceByAddressResponse;
    }
}
