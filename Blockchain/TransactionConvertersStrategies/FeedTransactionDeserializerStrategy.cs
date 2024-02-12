using System.Text.Json;

namespace HushEcosystem.Model.Blockchain.TransactionConvertersStrategies;

public class FeedTransactionDeserializerStrategy : ISpecificTransactionDeserializer
{
    public bool CanHandle(string transactionType)
    {
        if (transactionType == Feed.TypeCode)
        {
            return true;
        }

        return false;
    }

    public TransactionBase Handle(string rawText)
    {
        var transaction = JsonSerializer.Deserialize<Feed>(rawText);

        return transaction;
    }
}
