using System.Text.Json;

namespace HushEcosystem.Model.Blockchain.TransactionConvertersStrategies;

public class FeedMessageTransactionDeserializerStrategy : ISpecificTransactionDeserializer
{
    public bool CanHandle(string transactionType)
    {
        if (transactionType == FeedMessage.TypeCode)
        {
            return true;
        }

        return false;
    }

    public TransactionBase Handle(string rawText)
    {
        var transaction = JsonSerializer.Deserialize<FeedMessage>(rawText);

        return transaction;
    }
}
