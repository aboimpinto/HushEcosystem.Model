namespace HushEcosystem.Model.Blockchain.TransactionHandlerStrategies;

public interface ITransactionHandlerStrategy
{
    bool CanHandle(TransactionBase transactionBase);

    Task Handle(TransactionBase transactionBase);
}
