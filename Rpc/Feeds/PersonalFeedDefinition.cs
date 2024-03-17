using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Feeds;

public class PersonalFeedDefinition : IFeedDefinition
{
    public static string CommandId = "4e730e78-7eba-4b46-8169-aebee618e28b";

    public string Id { get; set; } = string.Empty;

    public string FeedId { get; set; } = string.Empty;

    public string FeedTitle { get; set; } = string.Empty;

    public FeedTypeEnum FeedType { get; set; }

    public double BlockIndex { get; set; }

    public string FeedOwner { get; set; } = string.Empty;

    public PersonalFeedDefinition()
    {
        this.Id = CommandId;
        this.FeedType = FeedTypeEnum.Personal;
    }
}
