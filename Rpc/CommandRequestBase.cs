namespace HushEcosystem.Model.Rpc;

public abstract class CommandRequestBase
{
    public string Command { get; set; } = string.Empty;

     public abstract string ToJson(TransactionBaseConverter options);
}
