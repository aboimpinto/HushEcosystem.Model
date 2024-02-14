using HushEcosystem.Model.Rpc.Blockchain;

namespace HushEcosystem.Model.GlobalEvents;

public class BlockchainHeightRespondedEvent
{
    public string ChannelId { get; } = string.Empty;

    public BlockchainHeightResponse BlockchainHeightResponse { get; }

    public BlockchainHeightRespondedEvent(string channerId, BlockchainHeightResponse blockchainHeightResponse)
    {
        this.ChannelId = channerId;
        this.BlockchainHeightResponse = blockchainHeightResponse;
    }
}
