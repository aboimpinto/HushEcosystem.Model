using System.Text.Json;
using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Profiles;

public class SearchAccountByPublicKeyResponse : CommandResponseBase
{
    public static string CommandCode = "f62db5e7-b5bd-4b60-a5f4-51952b23d060";

    public UserProfile UserProfile { get; set; }

    public SearchAccountByPublicKeyResponse()
    {
        this.Command = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
