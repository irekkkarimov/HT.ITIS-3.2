using Homework1.GraphQL.QueryService.Queries;

namespace Homework1.GraphQL.QueryService.Configurations;

public static class GraphQLConfiguration
{
    public static IServiceCollection AddGraphQLConfigured(this IServiceCollection services)
    {
        services
            .AddGraphQLServer()
            .AddPagingArguments()
            .AddSorting()
            .AddQueryType<SomeQuery>();

        return services;
    }
}