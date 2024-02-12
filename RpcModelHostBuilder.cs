using HushEcosystem.Model;
using HushEcosystem.Model.Rpc.CommandDeserializeStrategies;
using HushEcosystem.Model.Blockchain.TransactionConvertersStrategies;
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

        serviceCollection.AddTransient<ISpecificTransactionDeserializer, BlockCreationTransactionDeserializer>();

        serviceCollection.AddSingleton<ICommandDeserializeStrategy, HandshakeRequestDeserializeStrategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, HandshakeRespondedDeserializeStrategy>();

        serviceCollection.AddSingleton<ICommandDeserializeStrategy, BlockchainHeightRequestDeserializeStategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, BlockchainHeightRespondedDeserializeStategy>();

        serviceCollection.AddSingleton<ICommandDeserializeStrategy, TransactionsWithAddressRequestDeserializeStrategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, TransactionsWithAddressRespondedDeserializeStrategy>();

        serviceCollection.AddSingleton<ICommandDeserializeStrategy, BalanceByAddressRequestDeserializeStrategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, BalanceByAddressResponseDeserializeStrategy>();

        serviceCollection.AddSingleton<ICommandDeserializeStrategy, NewFeedRequestDeserializeStrategy>();
    }
}
