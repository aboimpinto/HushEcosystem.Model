using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public abstract class TransactionBase : ITransaction
{
    public string TransactionId { get; } = string.Empty;

    public string Type { get; } = string.Empty;

    public string BlockId { get; } = string.Empty;

    public double BlockHeight { get; }

    public string Issuer { get; } = string.Empty;

    public string Signature { get; set; } = string.Empty;

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