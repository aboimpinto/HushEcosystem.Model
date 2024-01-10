namespace HushEcosystem.Model.Blockchain;

public interface ITransaction: ISignable
{
    string TransactionId { get; }

    string Type { get; }

    string BlockId { get; }

    string Issuer { get; }
}
