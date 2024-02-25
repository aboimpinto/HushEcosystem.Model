using System.Text.Json;
using HushEcosystem.Model.GlobalEvents;
using HushEcosystem.Model.Rpc.Blockchain;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class BlockchainHeightRequestDeserializeStategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;

    public BlockchainHeightRequestDeserializeStategy(IEventAggregator eventAggregator)
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

            if (command == BlockchainHeightRequest.CommandCode)
            {
                return true;
            }

            return false;
        }
    }

    public async Task Handle(string commandJson, string channelId)
    {
        var command = JsonSerializer.Deserialize<BlockchainHeightRequest>(commandJson);

        if (command == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the BlockchainHeightRequest command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new BlockchainHeightRequestedEvent(channelId, command));
    }
}
