using System.Text.Json;
using HushEcosystem.Model.Rpc.GlobalEvents;
using HushEcosystem.Model.Rpc.Transactions;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class TransactionsWithAddressRequestDeserializeStrategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;
    private readonly TransactionBaseConverter _transactionBaseConverter;

    public TransactionsWithAddressRequestDeserializeStrategy(
        TransactionBaseConverter transactionBaseConverter,
        IEventAggregator eventAggregator)
    {
        this._transactionBaseConverter = transactionBaseConverter;
        this._eventAggregator = eventAggregator;
    }

    public bool CanHandle(string commandJson)
    {
        using (var jsonDocument = JsonDocument.Parse(commandJson))
        {
            var element = jsonDocument.RootElement;
            var command = element.GetProperty("Command").GetString();

            if (command == TransactionsWithAddressRequest.CommandCode)
            {
                return true;
            }

            return false;
        }
    }

    public async Task Handle(string commandJson, string channelId)
    {
        var jsonOptions = new JsonSerializerOptions
        {
            Converters = { this._transactionBaseConverter }
        };

        var handshakeResponse = JsonSerializer.Deserialize<TransactionsWithAddressRequest>(commandJson, jsonOptions);

        if (handshakeResponse == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the TransationsWithAddressRequest command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new TransactionsWithAddressRequestedEvent(channelId, handshakeResponse));
    }
}
