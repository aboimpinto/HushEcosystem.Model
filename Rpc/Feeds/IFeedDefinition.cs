using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Feeds;

public interface IFeedDefinition
{
    string Id { get; set; }

    string FeedId { get; set; }
    
    string FeedTitle { get; set; }

    FeedTypeEnum FeedType { get; set; }

    double BlockIndex { get; set; }
}
