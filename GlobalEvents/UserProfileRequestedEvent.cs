using HushEcosystem.Model.Rpc.Profiles;

namespace HushEcosystem.Model.GlobalEvents;

public class UserProfileRequestedEvent
{
    public string ChannelId { get; } = string.Empty;

    public UserProfileRequest UserProfileRequest { get; }

    public UserProfileRequestedEvent(string channerId, UserProfileRequest request)
    {
        this.ChannelId = channerId;
        this.UserProfileRequest = request;
    }        
}
