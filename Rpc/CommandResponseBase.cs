using System.Text.Json;

namespace HushEcosystem.Model.Rpc;

public abstract class CommandResponseBase : CommandRequestBase
{
    public bool Result { get; set; }

    public string FailureReason { get; set; } = string.Empty;    
}
