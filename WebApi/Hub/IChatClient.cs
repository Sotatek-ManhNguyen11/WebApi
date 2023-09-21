namespace WebApi.Hub
{
    public interface IChatClient
    {
        Task SayHello(string message);
        Task ReceiveMessage(string user, string message);
    }
}
