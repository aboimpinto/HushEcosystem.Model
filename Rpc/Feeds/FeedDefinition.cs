using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Feeds;

public class FeedDefinition
{
    public static string CommandId = "d3636955-36bf-4bcc-a20c-71e8226327b5";

    public string Id { get; set; } = string.Empty;

    public string FeedId { get; set; } = string.Empty;

    public string FeedTitle { get; set; } = string.Empty;

    public string FeedParticipant { get; set; } = string.Empty;

    public FeedTypeEnum FeedType { get; set; }

    public double BlockIndex { get; set; }

    public FeedDefinition()
    {
        this.Id = CommandId;
    }
}
