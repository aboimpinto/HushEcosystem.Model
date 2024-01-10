namespace HushEcosystem.Model.Blockchain;

public interface IBlock : ISignable
{
    string BlockId { get; }

    string TimeStamp { get; }
    
    IEnumerable<TransactionBase> Transactions { get; set; }             // TODO [AboimPinto]: this should be ReadOnly
    
    double Index { get; }    
    
    string Hash { get; }    
    
    string PreviousBlockId { get; }
    
    string NextBlockId { get; }

    
}
