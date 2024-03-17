// using HushEcosystem.Model.Blockchain;
// using HushEcosystem.Model.Rpc.Feeds;

// namespace HushEcosystem.Model.Builders;

// public class FeedDefinitionBuilder
// {
//     private string _feedId = string.Empty;
//     private FeedTypeEnum _feedType;
//     private string _participantAddress = string.Empty;
//     private string _feedTittle = "N/A";
//     private double _blockIndex;

//     public FeedDefinitionBuilder WithFeedId(string feedId)
//     {
//         this._feedId = feedId;
//         return this;
//     }

//     public FeedDefinitionBuilder WithFeedType(FeedTypeEnum feedType)
//     {
//         this._feedType = feedType;
//         return this;
//     }

//     public FeedDefinitionBuilder WithParticipantAddress(string participantAddress)
//     {
//         this._participantAddress = participantAddress;
//         return this;
//     }

//     public FeedDefinitionBuilder WithFeedTitle(string feedTittle)
//     {
//         this._feedTittle = feedTittle;
//         return this;
//     }

//     public FeedDefinitionBuilder WithBlockIndex(double blockIndex)
//     {
//         this._blockIndex = blockIndex;
//         return this;
//     }

//     public FeedDefinition Build()
//     {
//         return new FeedDefinition
//         {
//             FeedId = this._feedId,
//             FeedType = this._feedType,
//             // FeedParticipant = this._participantAddress,
//             FeedTitle = this._feedTittle,
//             BlockIndex = this._blockIndex
//         };
//     }

// }
