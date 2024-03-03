using System.Text.Json;
using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Profiles;

public class UserProfileRequest : CommandRequestBase
{
    public static string CommandCode = "a8f02f80-fa89-4f92-97cb-d8b97dfd3195";

    public UserProfile UserProfile { get; set; }

    public UserProfileRequest()
    {
        this.Command = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
