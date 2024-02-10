namespace HushEcosystem.Model.Blockchain;

public interface IValueableTransaction
{
    double Value { get; set; }

    string Token { get; set; }
}
