using System.Text.Json;
using HushEcosystem.Model.Rpc.GlobalEvents;
using HushEcosystem.Model.Rpc.Transactions;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class TransationsWithAddressRequestDeserializeStrategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;

    public TransationsWithAddressRequestDeserializeStrategy(IEventAggregator eventAggregator)
    {
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
        var handshakeResponse = JsonSerializer.Deserialize<TransationsWithAddressRequest>(commandJson);

        if (handshakeResponse == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the HandShakeResponse command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new TransationsWithAddressRequestedEvent(channelId, handshakeResponse));
    }
}
