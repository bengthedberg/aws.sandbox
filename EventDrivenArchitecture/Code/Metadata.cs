public class Metadata{
    public Guid EventId { get; } 
    public DateTime EventTime { get; }
    public string? Location { get; }

    public Metadata(Guid eventId, DateTime eventTime)
    {
        EventId = eventId,
        EventTime = eventTime;
        Location = GetLocation();
    }

    private GetLocation()
    {
        return Environment.MachineName;
    }
}