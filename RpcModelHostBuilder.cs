using HushEcosystem.Model;
using HushEcosystem.Model.Rpc.CommandDeserializeStrategies;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HushEcosystem;

public static class RpcModelHostBuilder
{
    public static IHostBuilder RegisterRpcModel(this IHostBuilder builder)
    {
        builder.ConfigureServices((hostContext, services) =>
        {
            Register(services);
        });

        return builder;
    }

    public static IServiceCollection RegisterRpcModel(this IServiceCollection serviceCollection)
    {
        Register(serviceCollection);

        return serviceCollection;
    }

    private static void Register(IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<TransactionBaseConverter>();

        serviceCollection.AddSingleton<ICommandDeserializeStrategy, HandshakeRequestDeserializeStrategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, HandshakeResponseDeserializeStrategy>();

        serviceCollection.AddSingleton<ICommandDeserializeStrategy, TransationsWithAddressRequestDeserializeStrategy>();
    }
}