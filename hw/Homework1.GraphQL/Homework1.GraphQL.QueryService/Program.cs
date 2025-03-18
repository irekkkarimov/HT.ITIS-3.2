using Homework1.GraphQL.Common.Entities;
using Homework1.GraphQL.QueryService.Configurations;
using Homework1.GraphQL.QueryService.Contexts;
using Homework1.GraphQL.QueryService.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseInMemoryDatabase("Homework1.GraphQL.QueryService");
});
builder.Services.AddScoped<IDataSeeder, DataSeeder>();
builder.Services.AddGraphQLConfigured();

var app = builder.Build();

using var scope = app.Services.CreateScope();
var dataSeeder = scope.ServiceProvider.GetRequiredService<IDataSeeder>();
dataSeeder.Seed();

app.UseHttpsRedirection();

app.MapGraphQL();
app.RunWithGraphQLCommands(args);