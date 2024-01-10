namespace HushEcosystem.Model.Rpc.Handshake;

public class HandshakeRequestBuilder
{
    private ClientType _clientType = ClientType.ClientNode;
    private string _nodeId = "N/A";
    private string _nodeAddressResponsabile = "N/A";

    public HandshakeRequestBuilder WithClientType(ClientType clientType)
    {
        this._clientType = clientType;

        return this;
    }

    public HandshakeRequestBuilder WithNodeId(string nodeId)
    {
        this._nodeId = nodeId;

        return this;
    }

    public HandshakeRequestBuilder WithNodeAddressResonsabile(string nodeAddressResonsabile)
    {
        this._nodeAddressResponsabile = nodeAddressResonsabile;
        
        return this;
    }

    public HandshakeRequest Build()
    {
        // TODO [AboimPinto]: Validate if the NodeId and NodeAddressResponsabile are valid

        return new HandshakeRequest
        {
            ClientType = this._clientType,
            NodeId = this._nodeId,
            NodeResonsabileAddress = this._nodeAddressResponsabile
        };
    }
}
