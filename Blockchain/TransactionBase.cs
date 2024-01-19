using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public abstract class TransactionBase : ITransaction
{
    public string TransactionId { get; set; } = string.Empty;

    public string Type { get; set; } = string.Empty;

    public string BlockId { get; set; } = string.Empty;

    public double BlockHeight { get; set; }

    public string Issuer { get; set; } = string.Empty;

    public string Signature { get; set; } = string.Empty;

    public TransactionBase()
    {
        
    }

    public TransactionBase(string transactionType, string blockId, string transactionIssuer, double blockHeight)
    {
        this.Type = transactionType;
        this.BlockId = blockId;
        this.Issuer = transactionIssuer;
        this.BlockHeight = blockHeight;

        this.TransactionId = Guid.NewGuid().ToString();
    }

    public string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}