namespace HushEcosystem.Model.Rpc.Transactions;

public class BalanceByAddressResponseBuilder
{
    private double _balance;

    public BalanceByAddressResponseBuilder WithBalance(double balance)
    {
        this._balance = balance;
        return this;
    }

    public BalanceByAddressResponse Build()
    {
        return new BalanceByAddressResponse
        {
            Balance = this._balance
        };
    }
}
