namespace HushEcosystem.Model.Rpc.Feeds;

public class FeedMessageDefinition
{
    public string FeedId { get; set; } = string.Empty;

    public string FeedMessageId { get; set; } = string.Empty;

    public string MessageContent { get; set; } = string.Empty;

    public string IssuerPublicAddress { get; set; } = string.Empty;

    public string IssuerName { get; set; } = string.Empty;

    public double BlockIndex { get; set; }
}
