using System.Text.Json;

namespace HushEcosystem.Model.Rpc.GlobalEvents.Blockchain
{
    public class BlockchainHeightRespose : CommandResponseBase
    {
        public double Height { get; set; }

        public override string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}