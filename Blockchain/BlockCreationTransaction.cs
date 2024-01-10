namespace HushEcosystem.Model.Blockchain;

public class BlockCreationTransaction : TransactionBase
{
    public double Reward { get; set; }

    public BlockCreationTransaction(string blockId, string issuer, double blockHeight) : base(
        "8e29c7c1-f2d8-4ff3-9d97-e927e3f40c79",
        blockId,
        issuer,
        blockHeight)
    {
        this.Reward = 0.5;          // TODO [AboimPinto]: this value is decided by the network. 
    }
}    
