using System.Text.Json;

namespace HushEcosystem.Model.Rpc;

public abstract class CommandRequestBase
{
    public string Command { get; set; } = string.Empty;

     public abstract string ToJson(JsonSerializerOptions options);
}
