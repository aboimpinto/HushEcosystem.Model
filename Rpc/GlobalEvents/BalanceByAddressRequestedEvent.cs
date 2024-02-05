using HushEcosystem.Model.Rpc.Blockchain;
using HushEcosystem.Model.Rpc.Transactions;

namespace HushEcosystem.Model.Rpc.GlobalEvents;

public class BalanceByAddressRequestedEvent
{
    public string ChannelId { get; } = string.Empty;

    public BalanceByAddressRequest BalanceByAddressRequest { get; }

    public BalanceByAddressRequestedEvent(string channerId, BalanceByAddressRequest balanceByAddressRequest)
    {
        this.ChannelId = channerId;
        this.BalanceByAddressRequest = balanceByAddressRequest;
    }
}
