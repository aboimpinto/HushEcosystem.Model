using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Builders;

public class FeedMessageBuilder
{
    private string _feedId = string.Empty;
    private string _message = string.Empty;
    private string _issuerPublicAddress = string.Empty;

    public FeedMessageBuilder WithFeedId(string feedId)
    {
        this._feedId = feedId;
        return this;
    }

    public FeedMessageBuilder WithMessage(string message)
    {
        this._message = message;
        return this;
    }

    public FeedMessageBuilder WithMessageIssuer(string issuerPublicAddress)
    {
        this._issuerPublicAddress = issuerPublicAddress;
        return this;
    }

    public FeedMessage Build()
    {
        return new FeedMessage()
        {
            FeedMessageId = Guid.NewGuid().ToString(),
            FeedId = this._feedId,
            Message = this._message,
            Issuer = this._issuerPublicAddress,
            TransactionId = FeedMessage.TypeCode,
            TimeStamp = DateTime.UtcNow
        };
    }    
}
