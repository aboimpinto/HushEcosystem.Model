using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Profiles;

public class SearchAccountByPublicKeyResponseBuilder 
{
    private UserProfile _userProfile;
    private string _failureReason = string.Empty;
    private bool _result = true;

    public SearchAccountByPublicKeyResponseBuilder WithUserProfile(UserProfile userProfile)
    {
        this._userProfile = userProfile;
        return this;
    }

    public SearchAccountByPublicKeyResponseBuilder WithFailureReason(string reason)
    {
        this._failureReason = reason;   
        if (string.IsNullOrWhiteSpace(reason))
        {
            this._result = true;
        }
        else
        {
            this._result = false;
        }

        return this;
    } 

    public SearchAccountByPublicKeyResponse Build()
    {
        return new SearchAccountByPublicKeyResponse
        {
            UserProfile = this._userProfile,
            FailureReason = this._failureReason,
            Result = this._result
        };
    }    
}
