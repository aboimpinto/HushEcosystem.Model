using System.Text.Json;
using HushEcosystem.Model.GlobalEvents;
using HushEcosystem.Model.Rpc.Transactions;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class BalanceByAddressRequestDeserializeStrategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;

    public BalanceByAddressRequestDeserializeStrategy(IEventAggregator eventAggregator)
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

            if (command == BalanceByAddressRequest.CommandCode)
            {
                return true;
            }

            return false;
        }
    }

    public async Task Handle(string commandJson, string channelId)
    {
        var command = JsonSerializer.Deserialize<BalanceByAddressRequest>(commandJson);

        if (command == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the BalanceByAddressRequest command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new BalanceByAddressRequestedEvent(channelId, command));
    }

}