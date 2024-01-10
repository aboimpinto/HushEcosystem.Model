using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public interface ISignable
{
    string Signature { get; set; }

    string ToJson(JsonSerializerOptions options);
}