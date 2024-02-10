using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public class Block: IBlock
{
    public string BlockId { get; } = string.Empty;

    public string TimeStamp { get; } = string.Empty;

    public IList<VerifiedTransaction> Transactions { get; set; }

    public double Index { get; }

    public string Hash { get; private set; } = string.Empty;

    public string PreviousBlockId { get; } = string.Empty;

    public string NextBlockId { get; } = string.Empty;

    public string Signature { get; set; } = string.Empty;

    public Block(string blockId, string previousBlockId, string nextBlockId, double index)
    {
        this.Transactions = new List<VerifiedTransaction>();

        this.TimeStamp = DateTime.UtcNow.ToString();

        this.PreviousBlockId = previousBlockId;
        this.NextBlockId = nextBlockId;

        this.BlockId = blockId;
        this.Index = index;
    }

    public void FinalizeBlock()
    {
        this.Hash = this.GetHashCode().ToString();
    }

    public string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
