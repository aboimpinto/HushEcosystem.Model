using System.Collections.Generic;
using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Feeds;

public class FeedsForAddressResponse : RpcResponseBase
{
    public static string CommandCode = "58a04403-bf8e-4dd6-b120-b8ad2ab7a5ee";

    public List<FeedDefinition> FeedDefinitions { get; set; }

    public FeedsForAddressResponse()
    {
        this.RPCMethodId = CommandCode;
    }

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}
