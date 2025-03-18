using Homework1.GraphQL.MutationService.Mutations;
using Homework1.GraphQL.MutationService.Queries;

namespace Homework1.GraphQL.MutationService.Configurations;

public static class GraphQLConfiguration
{
    public static IServiceCollection AddGraphQLConfigured(this IServiceCollection services)
    {
        services
            .AddGraphQLServer()
            .AddPagingArguments()
            .AddSorting()
            .AddQueryType<SomeQuery>()
            .AddMutationType<SomeMutation>();

        return services;
    }
}