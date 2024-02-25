using System.Text.Json;
using HushEcosystem.Model.GlobalEvents;
using HushEcosystem.Model.Rpc.Handshake;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class HandshakeRespondedDeserializeStrategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;

    public HandshakeRespondedDeserializeStrategy(IEventAggregator eventAggregator)
    {
        this._eventAggregator = eventAggregator;
    }

    public bool CanHandle(string commandJson)
    {
        if (string.IsNullOrWhiteSpace(commandJson))
        {
            return false;
        }

        using (var jsonDocument = JsonDocument.Parse(commandJson))
        {
            var element = jsonDocument.RootElement;
            var command = element.GetProperty("Command").GetString();

            if (command == HandshakeResponse.CommandCode)
            {
                return true;
            }

            return false;
        }
    }

    public async Task Handle(string commandJson, string channelId)
    {
        var handshakeResponse = JsonSerializer.Deserialize<HandshakeResponse>(commandJson);

        if (handshakeResponse == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the HandShakeResponse command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new HandshakeRespondedEvent(channelId, handshakeResponse));
    }
}
