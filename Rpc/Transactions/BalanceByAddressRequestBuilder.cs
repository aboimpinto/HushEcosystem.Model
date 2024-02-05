namespace HushEcosystem.Model.Rpc.Transactions;

public class BalanceByAddressRequestBuilder
{
    private string _address = string.Empty;

    public BalanceByAddressRequestBuilder WithAddress(string address)
    {
        this._address = address;

        return this;
    }

    public BalanceByAddressRequest Build()
    {
        return new BalanceByAddressRequest
        {
            Address = this._address
        };
    }    
}
