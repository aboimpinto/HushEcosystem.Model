using System.Collections.Generic;

namespace HushEcosystem.Model.Blockchain;

public interface IBlock : ISignable
{
    string BlockId { get; }

    string TimeStamp { get; }
    
    IList<VerifiedTransaction> Transactions { get; set; }             // TODO [AboimPinto]: this should be ReadOnly
    
    double Index { get; }    
    
    string Hash { get; }    
    
    string PreviousBlockId { get; }
    
    string NextBlockId { get; }

    
}
