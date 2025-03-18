using Homework1.GraphQL.SubscriptionService.BackgroundWorkers;
using Homework1.GraphQL.SubscriptionService.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLConfigured();
builder.Services.AddHostedService<SubscriptionTrigger>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseWebSockets();
app.MapGraphQL();
app.RunWithGraphQLCommands(args);
