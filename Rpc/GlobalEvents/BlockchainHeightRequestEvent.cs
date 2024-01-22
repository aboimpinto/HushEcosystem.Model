using HushEcosystem.Model.Rpc.Blockchain;

namespace HushEcosystem.Model.Rpc.GlobalEvents;

public class BlockchainHeightRequestEvent
{
    public string ChannelId { get; } = string.Empty;

    public BlockchainHeightRequest BlockchainHeightRequest { get; }

    public BlockchainHeightRequestEvent(string channerId, BlockchainHeightRequest blockchainHeightRequest)
    {
        this.ChannelId = channerId;
        this.BlockchainHeightRequest = BlockchainHeightRequest;
    }
}
