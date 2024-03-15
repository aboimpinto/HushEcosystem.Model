using System;
using HushEcosystem.Model.Blockchain;

namespace HushServerNode.Blockchain.Builders
{
    public class BlockCreationTransactionBuilder
    {
        private string _issuerAddress = string.Empty;

        public BlockCreationTransactionBuilder WithIssuerAddress(string issuerAddress)
        {
            this._issuerAddress = issuerAddress;
            return this;
        }

        public BlockCreationTransaction Build()
        {
            var transaction = new BlockCreationTransaction
            {
                Issuer = this._issuerAddress,
                Value = 0.5,                                        // TODO: This should be configurable by the network.
                Token = "HUSH",                                     
                TimeStamp = DateTime.UtcNow,
                Id = BlockCreationTransaction.TypeCode
            };

            return transaction;
        }
    }
}