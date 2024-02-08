namespace HushEcosystem.Model.Blockchain;

public class Feed : TransactionBase
{
    public static string TypeCode = "61791ba0-ef29-439a-8fcc-5c3d4c73d101";

    public string FeedId { get; set; } = string.Empty;

    public bool IsFeedEncrypted { get; set; } = true;

    public string FeedDetails { get; set; } = string.Empty;

    public Feed()
    {
    }

    public Feed(string blockId, string issuer, double blockHeight) : base(
        TypeCode,
        blockId,
        issuer,
        blockHeight)
    {
         
    }

    
}
