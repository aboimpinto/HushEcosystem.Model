using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using HushEcosystem.Model.Rpc.GlobalEvents;
using HushEcosystem.Model.Rpc.Transactions;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class TransationsWithAddressRequestDeserializeStrategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;
    private readonly TransactionBaseConverter _transactionBaseConverter;

    public TransationsWithAddressRequestDeserializeStrategy(
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

            if (command == TransationsWithAddressRequest.CommandCode)
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

        var handshakeResponse = JsonSerializer.Deserialize<TransationsWithAddressRequest>(commandJson, jsonOptions);

        if (handshakeResponse == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the TransationsWithAddressRequest command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new TransationsWithAddressRequestedEvent(channelId, handshakeResponse));
    }
}
