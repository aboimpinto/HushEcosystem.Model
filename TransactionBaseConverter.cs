using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using HushEcosystem.Model.Blockchain;
using HushEcosystem.Model.Blockchain.TransactionConvertersStrategies;

namespace HushEcosystem.Model;

public class TransactionBaseConverter : JsonConverter<TransactionBase>
{
    private readonly IEnumerable<ISpecificTransactionDeserializer> _transactionDeserializer;
        
    public TransactionBaseConverter(IEnumerable<ISpecificTransactionDeserializer> transactionDeserializer)
    {
        this._transactionDeserializer = transactionDeserializer;
    }

    public override TransactionBase? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // TODO: all this logic will be replaces by the ISpecificTransactionDeserliazer

        using (var jsonDocument = JsonDocument.ParseValue(ref reader))
        {
            var element = jsonDocument.RootElement;
            var transactionType = element.GetProperty("Id").GetString();

            var specificDeserializer = this._transactionDeserializer.SingleOrDefault(x => x.CanHandle(transactionType!));
            if (specificDeserializer != null)
            {
                return specificDeserializer.Handle(element.GetRawText());
            }

            throw new InvalidOperationException("No specific deserializer found for the transaction type.");
        }

        throw new NotImplementedException();
    }

    public override void Write(Utf8JsonWriter writer, TransactionBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
