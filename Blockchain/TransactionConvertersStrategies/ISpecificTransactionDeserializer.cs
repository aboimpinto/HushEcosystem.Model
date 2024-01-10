namespace HushEcosystem.Model.Blockchain.TransactionConvertersStrategies;

public interface ISpecificTransactionDeserializer
{
    bool CanHandle(string transactionType);

    TransactionBase Handle(string rawText);
}