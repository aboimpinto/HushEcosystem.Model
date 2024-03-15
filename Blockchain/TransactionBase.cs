using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public abstract class TransactionBase : IHashable, ISignable
{
    public string Id { get; set; } = string.Empty;

    public string Issuer { get; set; } = string.Empty;

    public string Hash { get; set; } = string.Empty;

    public string Signature { get; set; } = string.Empty;

    public abstract string ToJson(JsonSerializerOptions options);
}