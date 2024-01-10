namespace HushEcosystem.Model.Rpc.Transactions
{
    public class TransationsWithAddressRequestBuilder
    {
        private string _address = string.Empty;
        private int _lastHeightSynched;

        public TransationsWithAddressRequestBuilder WithAddress(string address)
        {
            this._address = address;

            return this;
        }

        public TransationsWithAddressRequestBuilder WithLastHeightSynched(int lastHeightSynched)
        {
            this._lastHeightSynched = lastHeightSynched;

            return this;
        }

        public TransationsWithAddressRequest Build()
        {
            return new TransationsWithAddressRequest
            {
                Address = this._address,
                LastHeightSynched = this._lastHeightSynched
            };
        }
    }
}