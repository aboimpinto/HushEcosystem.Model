using HushEcosystem.Model.Rpc.Profiles;

namespace HushEcosystem.Model.GlobalEvents;

public class SearchAccountByPublicKeyRequestedEvent
{
    public string ChannelId { get; } = string.Empty;

    public SearchAccountByPublicKeyRequest SearchAccountByPublicKeyRequest { get; }

    public SearchAccountByPublicKeyRequestedEvent(string channerId, SearchAccountByPublicKeyRequest request)
    {
        this.ChannelId = channerId;
        this.SearchAccountByPublicKeyRequest = request;
    }
}
