using Homework1.GraphQL.Common.Entities;
using Homework1.GraphQL.QueryService.Contexts;

namespace Homework1.GraphQL.QueryService.Queries;

public class SomeQuery()
{
    [GraphQLName("getPersons")]
    [UsePaging]
    [UseSorting]
    public IQueryable<Person> GetPersons([Service] AppDbContext appDbContext)
    {
        return appDbContext.Persons;
    }
}