using Homework1.GraphQL.MutationService;
using Homework1.GraphQL.MutationService.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDistributedMemoryCache();

builder.Services.AddGraphQLConfigured();

var app = builder.Build();


app.UseHttpsRedirection();

app.MapGraphQL();
app.RunWithGraphQLCommands(args);
