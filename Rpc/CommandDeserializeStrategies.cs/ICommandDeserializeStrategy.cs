using System.Threading.Tasks;

namespace HushEcosystem.Model.Rpc.CommandDeserializeStrategies;

public interface ICommandDeserializeStrategy
{
    bool CanHandle(string commandJson);

    Task Handle(string commandJson, string channelId);
}
