using HushEcosystem.Model.Blockchain;

namespace HushEcosystem.Model.Rpc.Transactions
{
    public class TransactionsWithAddressResponseBuilder
    {
        private IList<TransactionBase> _transactions = new List<TransactionBase>();

        public TransactionsWithAddressResponseBuilder WithTransactions(IEnumerable<TransactionBase> transactions)
        {
            this._transactions = new List<TransactionBase>(transactions);

            return this;
        }

        public TransactionsWithAddressResponse Build()
        {
            return new TransactionsWithAddressResponse
            {
                Transactions = this._transactions
            };
        }
    }
}