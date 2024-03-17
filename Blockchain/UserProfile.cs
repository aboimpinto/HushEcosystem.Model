using System.Collections.Generic;
using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public class UserProfile : TransactionBase
{
    public static string TypeCode = "57224bec-62b4-4f80-92e5-12a5546b7a8f";    

    public string UserPublicSigningAddress { get; set; } = string.Empty;

    public string UserPublicEncryptAddress { get; set; } = string.Empty;

    public string UserName { get; set; } = string.Empty;

    public bool IsPublic { get; set; }

    public List<string> Feeds { get; set; } = new List<string>();

    public UserProfile()
    {
        this.Id = TypeCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
