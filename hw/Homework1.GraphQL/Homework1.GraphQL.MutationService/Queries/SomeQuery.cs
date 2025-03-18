using System.Text.Json;
using Homework1.GraphQL.Common.Entities;
using Microsoft.Extensions.Caching.Distributed;

namespace Homework1.GraphQL.MutationService.Queries;

public class SomeQuery(IDistributedCache cache)
{
    [GraphQLName("getPerson")]
    public Person GetPerson(int id)
    {
        var person = cache.Get(id.ToString());

        if (person is null)
            throw new GraphQLException("Person not found");

        return JsonSerializer.Deserialize<Person>(person)!;
    }
}