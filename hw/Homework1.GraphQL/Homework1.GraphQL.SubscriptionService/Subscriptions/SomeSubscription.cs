namespace Homework1.GraphQL.SubscriptionService.Subscriptions;

public class SomeSubscription
{
    [Subscribe]
    [Topic("OnSomething")]
    public SomeResult OnSomething([EventMessage] int number)
    {
        return new SomeResult
        {
            Result = number
        };
    }
}

public class SomeResult
{
    public int Result { get; set; }
}