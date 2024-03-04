using System;
using System.Text.Json;
using System.Threading.Tasks;
using HushEcosystem.Model.GlobalEvents;
using HushEcosystem.Model.Rpc.Feeds;
using Olimpo;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public class SendFeedMessageRequestedDeserializeStrategy : ICommandDeserializeStrategy
{
    private readonly IEventAggregator _eventAggregator;
    private readonly TransactionBaseConverter _transactionBaseConverter;

    public SendFeedMessageRequestedDeserializeStrategy(
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
            var command = element.GetProperty("Command").GetString();

            if (command == SendFeedMessageRequest.CommandCode)
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

        var request = JsonSerializer.Deserialize<SendFeedMessageRequest>(commandJson, jsonOptions);

        if (request == null)
        {
            throw new InvalidOperationException($"Cannot deserialize the SendMessageRequest command: {commandJson}");
        }

        await this._eventAggregator.PublishAsync(new SendFeedMessageRequestedEvent(channelId, request));
    }
}
