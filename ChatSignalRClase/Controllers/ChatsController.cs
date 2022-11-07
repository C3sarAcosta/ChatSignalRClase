using Microsoft.AspNetCore.Mvc;

namespace ChatSignalRClase.Controllers
{
    public class ChatsController : Controller
    {
        public static Dictionary<int, string> ListaChats = new Dictionary<int, string>()
        {
            { 1, "Contabilidad"},
            { 2, "Programacion"},
            { 3, "Pasar tareas"},
            { 4, "Pasar examenes"}
        };

        public IActionResult ListaDeChats()
        {
            return View(ListaChats);
        }

        public IActionResult Chat(int idChat)
        {
            return View("Chat", idChat);
        }
    }
}
