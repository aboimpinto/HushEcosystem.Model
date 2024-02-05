using HushEcosystem.Model.Rpc.Blockchain;

namespace HushEcosystem.Model.Rpc.GlobalEvents;

public class BlockchainHeightRequestedEvent
{
    public string ChannelId { get; } = string.Empty;

    public BlockchainHeightRequest BlockchainHeightRequest { get; }

    public BlockchainHeightRequestedEvent(string channerId, BlockchainHeightRequest blockchainHeightRequest)
    {
        this.ChannelId = channerId;
        this.BlockchainHeightRequest = BlockchainHeightRequest;
    }
}
