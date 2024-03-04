using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Transactions
{
    public class TransactionsWithAddressResponseBuilder
    {
        private IList<VerifiedTransaction> _transactions = new List<VerifiedTransaction>();
        private double _blockHeightSyncPoint;

        public TransactionsWithAddressResponseBuilder WithTransactions(IEnumerable<VerifiedTransaction> transactions)
        {
            this._transactions = new List<VerifiedTransaction>(transactions);

            return this;
        }

        public TransactionsWithAddressResponseBuilder WithBlockHeightSyncPoint(double blockHeightSyncPoint)
        {
            this._blockHeightSyncPoint = blockHeightSyncPoint;
            return this;
        }

        public TransactionsWithAddressResponse Build()
        {
            return new TransactionsWithAddressResponse
            {
                Transactions = this._transactions,
                BlockHeightSyncPoint = this._blockHeightSyncPoint
            };
        }
    }
}