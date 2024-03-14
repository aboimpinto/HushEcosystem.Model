using HushEcosystem.Model;
using HushEcosystem.Model.Rpc.CommandDeserializeStrategies;
using HushEcosystem.Model.Blockchain.TransactionConvertersStrategies;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HushEcosystem.Model.Blockchain.TransactionHandlerStrategies;

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

        serviceCollection.AddTransient<ITransactionHandlerStrategy, FeedTransactionHandlerStrategy>();
        serviceCollection.AddTransient<ITransactionHandlerStrategy, FeedMessageTransactionHandlerStrategy>();

        serviceCollection.AddTransient<ISpecificTransactionDeserializer, BlockCreationTransactionDeserializer>();
        serviceCollection.AddTransient<ISpecificTransactionDeserializer, FeedTransactionDeserializerStrategy>();
        serviceCollection.AddSingleton<ISpecificTransactionDeserializer, FeedMessageTransactionDeserializerStrategy>();

        serviceCollection.AddSingleton<ICommandDeserializeStrategy, HandshakeRequestDeserializeStrategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, HandshakeRespondedDeserializeStrategy>();

        serviceCollection.AddSingleton<ICommandDeserializeStrategy, BlockchainHeightRequestDeserializeStategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, BlockchainHeightRespondedDeserializeStategy>();

        serviceCollection.AddSingleton<ICommandDeserializeStrategy, TransactionsWithAddressRequestDeserializeStrategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, TransactionsWithAddressRespondedDeserializeStrategy>();

        serviceCollection.AddSingleton<ICommandDeserializeStrategy, BalanceByAddressRequestDeserializeStrategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, BalanceByAddressResponseDeserializeStrategy>();

        serviceCollection.AddSingleton<ICommandDeserializeStrategy, NewFeedRequestDeserializeStrategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, SendFeedMessageRequestedDeserializeStrategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, UserProfileRequestedDeserializeStrategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, SearchAccountByPublicKeyRequestDeserializeStrategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, SearchAccountByPublicKeyResponseDeserializeStrategy>();
        serviceCollection.AddSingleton<ICommandDeserializeStrategy, FeedsForAddressRequestDeserializeStrategy>();
    }
}
