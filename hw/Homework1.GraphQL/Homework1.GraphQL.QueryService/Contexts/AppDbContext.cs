using Homework1.GraphQL.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace Homework1.GraphQL.QueryService.Contexts;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{

    public DbSet<Person> Persons { get; set; } = null!;
}