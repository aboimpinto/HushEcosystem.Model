using HushEcosystem.Model.Rpc.Profiles;

namespace HushEcosystem.Model.Builders;

public class GetUserProfileRequestBuilder
{
    private string _publicAddress = string.Empty;

    public GetUserProfileRequestBuilder WithPublicAddress(string publicAddress)
    {
        this._publicAddress = publicAddress;
        return this;
    }   

    public GetUserProfileRequest Build()
    {
        return new GetUserProfileRequest
        {
            PublicAddress = this._publicAddress
        };
    }    
}
