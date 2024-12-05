using Microsoft.AspNetCore.Mvc;

namespace ColheitaSolidaria.Controllers
{
    public class Cadastro : Controller
    {
        public IActionResult EscolherCadastro()
        {
            ViewData["Title"] = "Escolha de Cadastro";
            return View();
        }
        public IActionResult CadastroRecebedor()
        {
            ViewData["Title"] = "Cadastro Receptor";
            return View();
        }
        public IActionResult CadastroColaborador()
        {
            ViewData["Title"] = "Cadastro COlaborador";
            return View();
        }
    }
}
