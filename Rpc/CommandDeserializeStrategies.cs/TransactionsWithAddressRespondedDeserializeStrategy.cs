using System.Text.Json;
using HushEcosystem.Model.Rpc.GlobalEvents;
using HushEcosystem.Model.Rpc.Transactions;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class TransactionsWithAddressRespondedDeserializeStrategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;

    private readonly TransactionBaseConverter _transactionBaseConverter;

    public TransactionsWithAddressRespondedDeserializeStrategy(
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

            if (command == TransactionsWithAddressResponse.CommandCode)
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

        var command = JsonSerializer.Deserialize<TransactionsWithAddressResponse>(commandJson, jsonOptions);

        if (command == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the TransactionsWithAddressResponse command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new TransactionsWithAddressRespondedEvent(channelId, command));
    }
}
