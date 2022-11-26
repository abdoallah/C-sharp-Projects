using Microsoft.AspNetCore.SignalR;

namespace SignalR.HubConfig
{
    public class MyHub:Hub
    {
        public async Task askServer(string message)
        {
            string tempString;
            if(message == "hey")
            {
                tempString = "message was hey";
            }
            else
            {
                tempString = "message was somthing else ";
            }
            await Clients.Clients(this.Context.ConnectionId).SendAsync("askServerResponse",tempString);
        }
    }
}
