namespace BenjaminAbt.Samples.WinFormsSpsRxNet.Providers
{
    public interface ISpsConnection
    {
        event InMemoryDemoSpsConnection.NewMessageHandler NewMessage;
    }
}
