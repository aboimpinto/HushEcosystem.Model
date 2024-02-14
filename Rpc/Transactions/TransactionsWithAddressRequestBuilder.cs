namespace HushEcosystem.Model.Rpc.Transactions
{
    public class TransationsWithAddressRequestBuilder
    {
        private string _address = string.Empty;
        private double _lastHeightSynched;

        public TransationsWithAddressRequestBuilder WithAddress(string address)
        {
            this._address = address;

            return this;
        }

        public TransationsWithAddressRequestBuilder WithLastHeightSynched(double lastHeightSynched)
        {
            this._lastHeightSynched = lastHeightSynched;

            return this;
        }

        public TransactionsWithAddressRequest Build()
        {
            return new TransactionsWithAddressRequest
            {
                Address = this._address,
                LastHeightSynched = this._lastHeightSynched
            };
        }
    }
}