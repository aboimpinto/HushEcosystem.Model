using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Builders;

public class FeedBuilder
{
    private string _feedSubscriber = string.Empty;
    private FeedTypeEnum _feedType;
    private string _publicEncriptAddress = string.Empty;
    private string _privateEncriptAddress = string.Empty;
    private string _feedParticipantPublicAddress = String.Empty;

    public FeedBuilder WithFeedOwner(string feedOwner)
    {
        this._feedSubscriber = feedOwner;
        return this;
    }

    public FeedBuilder WithFeedType(FeedTypeEnum feedType)
    {
        this._feedType = feedType;
        return this;
    }

    public FeedBuilder WithFeedParticipantPublicAddress(string feedParticipantPublicAddress)
    {
        this._feedParticipantPublicAddress = feedParticipantPublicAddress;
        return this;
    }

    public FeedBuilder WithPublicEncriptAddress(string publicEncriptAddress)
    {
        this._publicEncriptAddress = publicEncriptAddress;
        return this;
    }

    public FeedBuilder WithPrivateEncriptAddress(string privateEncriptAddress)
    {
        this._privateEncriptAddress = privateEncriptAddress;
        return this;
    }

    public Feed Build()
    {
        return new Feed()
        {
            TransactionId = Feed.TypeCode,
            FeedId = Guid.NewGuid().ToString(),
            FeedParticipantPublicAddress = this._feedParticipantPublicAddress,
            FeedPublicEncriptAddress = this._publicEncriptAddress,
            FeedPrivateEncriptAddress = this._privateEncriptAddress,
            FeedType = this._feedType,
            Issuer = this._feedSubscriber
        };
    }    
}
