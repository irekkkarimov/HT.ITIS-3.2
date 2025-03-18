using Homework1.GraphQL.Common.Entities;

namespace Homework1.GraphQL.MutationService;

public class PersonCollection
{
    private readonly List<Person> _persons = new()
    {
        new Person
        {
            Id = 1,
            Name = "Irek",
            Age = 21
        },
        new Person
        {
            Id = 2,
            Name = "Andrey",
            Age = 14
        },
        new Person
        {
            Id = 3,
            Name = "Vlad",
            Age = 37
        },
        new Person {
            Id = 4,
            Name = "Irek",
            Age = 20
        }
    };

    public void Add(Person person) => _persons.Add(person);

    public IReadOnlyList<Person> Get() => _persons.AsReadOnly();
}