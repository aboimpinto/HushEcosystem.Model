namespace HushEcosystem.Model.Rpc;

public abstract class CommandBase
{
    public string Command { get; set; } = string.Empty;

     public abstract string ToJson();
}
