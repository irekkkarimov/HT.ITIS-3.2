using HotChocolate.Subscriptions;

namespace Homework1.GraphQL.SubscriptionService.BackgroundWorkers;

public class SubscriptionTrigger(ITopicEventSender topicEventSender) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var random = new Random();
        
        while (true)
        {
            await topicEventSender.SendAsync("OnSomething", random.Next(), stoppingToken);
            await Task.Delay(1000, stoppingToken);
        }
    }
}