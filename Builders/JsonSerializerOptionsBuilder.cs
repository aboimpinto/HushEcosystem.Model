using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace HushEcosystem.Model.Builders;

public class JsonSerializerOptionsBuilder
{
    private TransactionBaseConverter? _transactionBaseConverter;

    private IList<Action<JsonTypeInfo>> _modifiers = new List<Action<JsonTypeInfo>>();

    public JsonSerializerOptionsBuilder WithTransactionBaseConverter(TransactionBaseConverter transactionBaseConverter)
    {
        this._transactionBaseConverter = transactionBaseConverter;
        return this;
    }

    public JsonSerializerOptionsBuilder WithModifierExcludeSignature()
    {
        this._modifiers.Add(x => TransactionBaseExtensions.ExcludeSignatureProperty(x));
        return this;
    }

    public JsonSerializerOptionsBuilder WithModifierExcludeHash()
    {
        this._modifiers.Add(x => TransactionBaseExtensions.ExcludeHashProperty(x));
        return this;
    }

    public JsonSerializerOptionsBuilder WithModifierExcludeBlockIndex()
    {
        this._modifiers.Add(x => TransactionBaseExtensions.ExcludeBlockIndexProperty(x));
        return this;
    }

    public JsonSerializerOptions Build()
    {
         if (this._transactionBaseConverter == null)
         {
            throw new InvalidOperationException("TransactionBaseConverter is required to build JsonSerializerOptions");
         }

        var typeInfoResover = new DefaultJsonTypeInfoResolver();
        foreach (var item in this._modifiers)
        {
            typeInfoResover.Modifiers.Add(item);
        }

        var jsonOptions = new JsonSerializerOptions
        {
            TypeInfoResolver = typeInfoResover,
            Converters = { this._transactionBaseConverter }
        };

        return jsonOptions;
    }

}
