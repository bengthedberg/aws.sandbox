
public class EventMessageBroker
{
    public void PublishEvent<TEvent>(TEvent @event,
        string source,
        string detailType,
        string eventBusName)
    {
        // Use the name of the event class to defined the detail type
        var detailType = e.GetType().Name;

        // Construct the Detail payload for the event with metadata
        var detail = new Details<TEvent>(e);

        var jsonSerializerOptions = new JsonSerializerOptions { IncludeFields = true };

        // Create the request
        var request = new PutEventRequest
        {
            Entries = new List<PutEventRequestEntry>
            {
                new()
                {
                    Source = source,
                    Detail = JsonSerializer.Serialize(detail, jsonSerializerOptions),
                    DetailType = detailType,
                    EventBusName = eventBusName
                }
            }
        };

        _eventBridgeClient.PutEventAsync(request);

    }
}