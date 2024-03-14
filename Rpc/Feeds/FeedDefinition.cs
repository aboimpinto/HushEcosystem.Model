using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Feeds;

public class FeedDefinition
{
    public VerifiedTransaction FeedTransaction { get; set; }

    public string FeedId { get; set; } = string.Empty;

    public string FeedTitle { get; set; } = string.Empty;

    public string FeedParticipant { get; set; } = string.Empty;

    public FeedTypeEnum FeedType { get; set; }

    public double BlockIndex { get; set; }
}
