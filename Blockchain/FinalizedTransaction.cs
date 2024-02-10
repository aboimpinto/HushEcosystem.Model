using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public class FinalizedTransaction : ISignable, IHashable
{
    public VerifiedTransaction VerifiedTransaction { get; set; }

    public string BlockGeneratorAddress { get; set; } = string.Empty;

    public string Hash { get; set; } = string.Empty;

    public string Signature { get; set; } = string.Empty;

    public string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
