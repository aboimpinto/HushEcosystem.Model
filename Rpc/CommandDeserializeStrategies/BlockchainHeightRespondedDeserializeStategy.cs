using System;
using System.Text.Json;
using System.Threading.Tasks;
using HushEcosystem.Model.GlobalEvents;
using HushEcosystem.Model.Rpc.Blockchain;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class BlockchainHeightRespondedDeserializeStategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;

    public BlockchainHeightRespondedDeserializeStategy(IEventAggregator eventAggregator)
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

        await this._eventAggregator.PublishAsync(new BlockchainHeightRespondedEvent(channelId, command));
    }
}
