using Microsoft.AspNetCore.SignalR;

namespace BackendSignalR
{
    public class Chat : Hub
    {
        public void NewMensage(string userName, string message)
        {
            Clients.All.SendAsync("newMessage", userName, message);
        }
    }
}
