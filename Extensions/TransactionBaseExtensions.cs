using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using HushEcosystem.Model.Blockchain;
using Olimpo;

namespace HushEcosystem.Model;

public static class TransactionBaseExtensions
{
    public static void Sign(this ISignable signableObject, string privateKey, JsonSerializerOptions options)
    {
        var json = signableObject.ToJson(options);
        signableObject.Signature = SigningKeys.SignMessage(json, privateKey);
    }

    public static void HashObject(this IHashable hashableObject, JsonSerializerOptions options)
    {
        var json = hashableObject.ToJson(options);
        hashableObject.Hash = json.GetHashCode().ToString();
    }

    public static bool CheckSignature(this ISignable signableObject, string signingAddress, JsonSerializerOptions options)
    {
        var json = signableObject.ToJson(options);
        return SigningKeys.VerifySignature(json, signableObject.Signature, signingAddress);
    }

    public static void ExcludeSignatureProperty(JsonTypeInfo jsonTypeInfo)
    {
        if (jsonTypeInfo.Kind != JsonTypeInfoKind.Object)
            return;

        foreach (JsonPropertyInfo property in jsonTypeInfo.Properties)
        {
            if (property.Name.Contains("Signature"))
            {
                property.Get = null;
                property.Set = null;
            }
        }
    }

    public static void ExcludeHashProperty(JsonTypeInfo jsonTypeInfo)
    {
        if (jsonTypeInfo.Kind != JsonTypeInfoKind.Object)
            return;

        foreach (JsonPropertyInfo property in jsonTypeInfo.Properties)
        {
            if (property.Name.Contains("Hash"))
            {
                property.Get = null;
                property.Set = null;
            }
        }
    }

    public static void ExcludeBlockIndexProperty(JsonTypeInfo jsonTypeInfo)
    {
        if (jsonTypeInfo.Kind != JsonTypeInfoKind.Object)
            return;

        foreach (JsonPropertyInfo property in jsonTypeInfo.Properties)
        {
            if (property.Name.Contains("BlockIndex"))
            {
                property.Get = null;
                property.Set = null;
            }
        }
    }
}
