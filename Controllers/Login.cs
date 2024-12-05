using Microsoft.AspNetCore.Mvc;

namespace ColheitaSolidaria.Controllers
{
    public class Login : Controller
    {
        public IActionResult Escolher()
        {
            ViewData["Title"] = "Escolha de Login";
            return View();
        }
        public IActionResult LoginColaborador()
        {
            ViewData["Title"] = "Login Colaborador";
            return View();
        }
        public IActionResult LoginRecebedor()
        {
            ViewData["Title"] = "Login Recebedor";
            return View();
        }
        public IActionResult LoginAdministrador()
        {
            ViewData["Title"] = "Login Administrador";
            return View();
        }
    }
}
