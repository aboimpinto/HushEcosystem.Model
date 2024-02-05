using System;
using System.Text.Json;
using HushEcosystem.Model.Rpc.GlobalEvents;
using HushEcosystem.Model.Rpc.Transactions;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies.cs;

public class BalanceByAddressResponseDeserializeStrategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;

    public BalanceByAddressResponseDeserializeStrategy(IEventAggregator eventAggregator)
    {
        this._eventAggregator = eventAggregator;
    }

    public bool CanHandle(string commandJson)
    {
        using (var jsonDocument = JsonDocument.Parse(commandJson))
        {
            var element = jsonDocument.RootElement;
            var command = element.GetProperty("Command").GetString();

            if (command == BalanceByAddressResponse.CommandCode)
            {
                return true;
            }

            return false;
        }
    }

    public async Task Handle(string commandJson, string channelId)
    {
        var command = JsonSerializer.Deserialize<BalanceByAddressResponse>(commandJson);

        if (command == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the BalanceByAddressResponse command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new BalanceByAddressRespondedEvent(channelId, command));
    }
}
