using Homework1.GraphQL.SubscriptionService.Subscriptions;

namespace Homework1.GraphQL.SubscriptionService.Configurations;

public static class GraphQLConfiguration
{
    public static IServiceCollection AddGraphQLConfigured(this IServiceCollection services)
    {
        services
            .AddGraphQLServer()
            .AddSubscriptionType<SomeSubscription>()
            .AddInMemorySubscriptions()
            .ModifyOptions(options =>
            {
                options.StrictValidation = false;
            });

        return services;
    }
}