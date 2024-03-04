using System;
using System.Text.Json;

namespace HushEcosystem.Model.Blockchain;

public class BlockCreationTransaction : TransactionBase, IValueableTransaction
{
    public static string TypeCode = "8e29c7c1-f2d8-4ff3-9d97-e927e3f40c79";

    public DateTime TimeStamp { get; set; }

    public double Value { get; set; }
    
    public string Token { get; set; } = string.Empty;

    public override string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }
}    
