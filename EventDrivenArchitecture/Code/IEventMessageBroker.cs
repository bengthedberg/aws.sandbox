namespace MyCompany.Shared.Events;ß

public interface IEventMessageBroker
{
    Task PublishEvent<TEvent>(TEvent @event,
        string source,
        string detailType,
        string eventBusName);
}