using Homework1.GraphQL.Common.Entities;
using Homework1.GraphQL.QueryService.Contexts;

namespace Homework1.GraphQL.QueryService.Services;

public class DataSeeder(AppDbContext appDbContext) : IDataSeeder
{
    public void Seed()
    {
        appDbContext.Persons.AddRange(new List<Person>
        {
            new()
            {
                Id = 1,
                Name = "Irek",
                Age = 21
            },
            new()
            {
                Id = 2,
                Name = "Andrey",
                Age = 14
            },
            new()
            {
                Id = 3,
                Name = "Vlad",
                Age = 37
            },
            new()
            {
                Id = 4,
                Name = "Irek",
                Age = 20
            }
        });

        appDbContext.SaveChanges();
    }
}