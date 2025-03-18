using System.Text;
using System.Text.Json;
using Homework1.GraphQL.Common.Entities;
using Microsoft.Extensions.Caching.Distributed;

namespace Homework1.GraphQL.MutationService.Mutations;

public class SomeMutation(IDistributedCache cache)
{
    public Person AddPerson(Person person)
    {
        cache.Set(person.Id.ToString(), Encoding.UTF8.GetBytes(JsonSerializer.Serialize(person)));
        return person;
    }
}