using Microsoft.AspNetCore.Mvc;

namespace ProjetoCliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Consultar()
        {
            return View();
        }
    }
}
