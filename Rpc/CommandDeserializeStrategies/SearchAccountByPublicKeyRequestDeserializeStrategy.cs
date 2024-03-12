using System;
using System.Text.Json;
using System.Threading.Tasks;
using HushEcosystem.Model.GlobalEvents;
using HushEcosystem.Model.Rpc.Profiles;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class SearchAccountByPublicKeyRequestDeserializeStrategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;
    private readonly TransactionBaseConverter _transactionBaseConverter;

    public SearchAccountByPublicKeyRequestDeserializeStrategy(
        TransactionBaseConverter transactionBaseConverter,
        IEventAggregator eventAggregator)
    {
        this._transactionBaseConverter = transactionBaseConverter;
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

            if (command == SearchAccountByPublicKeyRequest.CommandCode)
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

        var request = JsonSerializer.Deserialize<SearchAccountByPublicKeyRequest>(commandJson, jsonOptions);

        if (request == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the SearchAccountByPublicKeyRequest command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new SearchAccountByPublicKeyRequestedEvent(channelId, request));
    }
}
