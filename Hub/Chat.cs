using Microsoft.AspNetCore.SignalR;

namespace BackendSignalR
{
    public class Chat : Hub
    {
        public Task SendMessage(string userName, string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", userName, message);
        }

    }
}
