using System;
using System.Text.Json;
using System.Threading.Tasks;
using HushEcosystem.Model.GlobalEvents;
using HushEcosystem.Model.Rpc.Feeds;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class FeedMessagesForAddressRequestDeserializeStrategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;

    public FeedMessagesForAddressRequestDeserializeStrategy (IEventAggregator eventAggregator)
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

            if (command == FeedMessagesForAddressRequest.CommandCode)
            {
                return true;
            }

            return false;
        }
    }

    public async Task Handle(string commandJson, string channelId)
    {
        var command = JsonSerializer.Deserialize<FeedMessagesForAddressRequest>(commandJson);

        if (command == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the FeedMessagesForAddressRequest command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new FeedMessagesForAddressRequestedEvent(channelId, command));
    }
}
