using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRLec.Hubs
{
   public class ApplicationHub : Hub
   {
      public async Task SendMessageToAllAsync(string message)
      {
         await Clients.All.SendAsync("Notification", message);
      }
   }
}
