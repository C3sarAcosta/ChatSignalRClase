using Microsoft.AspNetCore.SignalR;

namespace ChatSignalRClase
{
    public class ChatHub : Hub
    {

        public async Task SenMessage(int room, string user, string message)
        {
            //Enviamos un mensaje de forma asincorna a un grupo determinado
            await Clients.Group(room.ToString()).SendAsync("RecibirMensaje", user, message);
        }

        public async Task AddToGroup(string room)
        {
            //Añadimos a la persona a la sala
            await Groups.AddToGroupAsync(Context.ConnectionId, room);
        }
    }
}
