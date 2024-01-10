using System.Text.Json;

namespace HushEcosystem.Model.Rpc.Transactions
{
    public class TransationsWithAddressRequest : CommandBase
    {
        public static string CommandCode = "TransationsWithAddressRequest";

        public string Address { get; set; } = string.Empty;

        public int LastHeightSynched { get; set; }

        public TransationsWithAddressRequest()
        {
            this.Command = CommandCode;
        }

        public override string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}