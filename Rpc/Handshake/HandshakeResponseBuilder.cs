namespace HushEcosystem.Model.Rpc.Handshake;

public class HandshakeResponseBuilder
{
    private bool _result;
    private string _reason = string.Empty;

    public HandshakeResponseBuilder WithResult(bool result)
    {
        this._result = result;

        return this;
    }

    public HandshakeResponseBuilder WithFailureReason(string reason)
    {
        this._reason = reason;

        return this;
    }

    public HandshakeResponse Build()
    {
        return new HandshakeResponse
        {
            Result = this._result,
            FailureReason = this._reason
        };
    }    
}
