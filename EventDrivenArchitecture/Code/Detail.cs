public class Detail<T>
{
    public Metadata Metadata { get; private set; }
    public T Data { get; private set; }

    public Detail(T data)
    {
        Metadata = new Metadata(Guid.NewGuid(), DateTime.UTCNow);
        Data = data;
    }
}
ß