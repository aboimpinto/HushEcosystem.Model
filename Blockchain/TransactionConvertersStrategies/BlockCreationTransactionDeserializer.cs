using System.Text.Json;

namespace HushEcosystem.Model.Blockchain.TransactionConvertersStrategies;

public class BlockCreationTransactionDeserializer : ISpecificTransactionDeserializer
{
    public bool CanHandle(string transactionType)
    {
        if (transactionType == BlockCreationTransaction.TypeCode)
        {
            return true;
        }

        return false;
    }

    public TransactionBase Handle(string rawText)
    {
        var transaction = JsonSerializer.Deserialize<BlockCreationTransaction>(rawText);

        return transaction;
    }
}
