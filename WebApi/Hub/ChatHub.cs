using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Localization;

namespace WebApi.Hub
{
    public class ChatHub : Hub<IChatClient>
    {
        private readonly IStringLocalizer<ChatHub> _localizer;

        public ChatHub(IStringLocalizer<ChatHub> localizer)
        {
            _localizer = localizer;
        }

        public async Task SayHello()
        {
            await Clients.Caller.SayHello(_localizer.GetString("Hello"));
        }

        public async Task SendMessage(string user, string message)
        => await Clients.All.ReceiveMessage(user, message);
    }
}
