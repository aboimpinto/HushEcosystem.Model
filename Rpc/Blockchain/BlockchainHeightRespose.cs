using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Blockchain
{
    public class BlockchainHeightRespose : CommandResponseBase
    {
        public static string CommandCode = "4b7bc14a-013f-41fe-90ef-f51c12499b6b";

        public double Height { get; set; }

        public BlockchainHeightRespose()
        {
            this.Command = CommandCode;
        }

        public override string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}