using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public interface IHashable
{
    string Hash { get; set; }

    string ToJson(JsonSerializerOptions options);    
}
