using System.Text.Json;
using HushEcosystem.Model.Rpc.Blockchain;
using HushEcosystem.Model.Rpc.GlobalEvents;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class BlockchainHeightResponseDeserializeStategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;

    public BlockchainHeightResponseDeserializeStategy(IEventAggregator eventAggregator)
    {
        this._eventAggregator = eventAggregator;
    }

    public bool CanHandle(string commandJson)
    {
        using (var jsonDocument = JsonDocument.Parse(commandJson))
        {
            var element = jsonDocument.RootElement;
            var command = element.GetProperty("Command").GetString();

            if (command == BlockchainHeightResponse.CommandCode)
            {
                return true;
            }

            return false;
        }
    }

    public async Task Handle(string commandJson, string channelId)
    {
        var command = JsonSerializer.Deserialize<BlockchainHeightResponse>(commandJson);

        if (command == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the BlockchainHeightResponse command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new BlockchainHeightResponseEvent(channelId, command));
    }
}
