using HushEcosystem.Model.Rpc.Blockchain;

namespace HushEcosystem.Model.Rpc.GlobalEvents;

public class BlockchainHeightResponseEvent
{
    public string ChannelId { get; } = string.Empty;

    public BlockchainHeightResponse BlockchainHeightResponse { get; }

    public BlockchainHeightResponseEvent(string channerId, BlockchainHeightResponse blockchainHeightResponse)
    {
        this.ChannelId = channerId;
        this.BlockchainHeightResponse = blockchainHeightResponse;
    }
}
