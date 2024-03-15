using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Builders;

public class UserProfileBuilder
{
    private string _publicSigningAddress = string.Empty;
    private string _publicEncryptAddress = string.Empty;
    private string _userName = string.Empty;
    private bool _isPublicProfile;

    public UserProfileBuilder WithPublicSigningAddress(string publicSigningAddress)
    {
        this._publicSigningAddress = publicSigningAddress;

        return this;
    }
        

    public UserProfileBuilder WithPublicEncryptAddress(string publicEncryptAddress)
    {
        this._publicEncryptAddress = publicEncryptAddress;
        return this;
    }

    public UserProfileBuilder WithUserName(string userName)
    {
        this._userName = userName;
        return this;
    }

    public UserProfileBuilder WithIsPublicFlag(bool isPublicProfile)
    {
        this._isPublicProfile = isPublicProfile;
        return this;
    }

    public UserProfile Build()
    {
        return new UserProfile
        {
            Id = UserProfile.TypeCode,
            Issuer = this._publicSigningAddress,
            UserPublicSigningAddress = this._publicSigningAddress,
            UserPublicEncryptAddress = this._publicEncryptAddress,
            UserName = string.IsNullOrEmpty(this._userName) ? "Anonymous" : this._userName,
            IsPublic = this._isPublicProfile
        };
    }
}
