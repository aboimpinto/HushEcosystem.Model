using System;
using System.Text.Json;
using System.Threading.Tasks;
using HushEcosystem.Model.GlobalEvents;
using HushEcosystem.Model.Rpc.Feeds;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class FeedsForAddressRequestDeserializeStrategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;

    public FeedsForAddressRequestDeserializeStrategy(IEventAggregator eventAggregator)
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
            var command = element.GetProperty("RPCMethodId").GetString();

            if (command == FeedsForAddressRequest.CommandCode)
            {
                return true;
            }

            return false;
        }
    }

    public async Task Handle(string commandJson, string channelId)
    {
        var command = JsonSerializer.Deserialize<FeedsForAddressRequest>(commandJson);

        if (command == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the FeedsForAddressRequest command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new FeedsForAddressRequestedEvent(channelId, command));
    }
}
