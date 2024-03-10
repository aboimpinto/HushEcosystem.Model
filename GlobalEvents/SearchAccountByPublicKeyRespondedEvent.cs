using HushEcosystem.Model.Rpc.Profiles;

namespace HushEcosystem.Model.GlobalEvents;

public class SearchAccountByPublicKeyRespondedEvent
{
    public string ChannelId { get; } = string.Empty;

    public SearchAccountByPublicKeyResponse SearchAccountByPublicKeyResponse { get; }

    public SearchAccountByPublicKeyRespondedEvent(string channerId, SearchAccountByPublicKeyResponse searchAccountByPublicKeyResponse)
    {
        this.ChannelId = channerId;
        this.SearchAccountByPublicKeyResponse = searchAccountByPublicKeyResponse;
    }
}
