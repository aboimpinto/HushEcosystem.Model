using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.GlobalEvents;

public class UserProfileTransactionHandledEvent
{
    public UserProfile UserProfile { get; }    

    public UserProfileTransactionHandledEvent(UserProfile userProfile)
    {
        this.UserProfile = userProfile;
    }
}
