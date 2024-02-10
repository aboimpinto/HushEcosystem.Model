using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public class VerifiedTransaction : ISignable, IHashable
{
    public required TransactionBase SpecificTransaction { get; set; }

    public string ValidatorAddress { get; set; } = string.Empty;

    public string Hash { get; set; } = string.Empty;

    public string Signature { get; set; } = string.Empty;

    public double BlockIndex { get; set; }

    public string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
