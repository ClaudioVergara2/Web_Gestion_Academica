using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApiNotas.Models;

namespace WebApiNotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Asignatura()
        {
            return View();
        }

        public IActionResult Semestre()
        {
            return View();
        }

        public IActionResult IngresoAsignatura()
        {
            return View();
        }

        public IActionResult IngresoCurso()
        {
            return View();
        }

        public IActionResult IniciarSesion(string username, string password)
        {
            if (username == "usuario" && password == "contraseña")
            {
                return RedirectToAction("Menu", "Home");
            }
            else
            {
                TempData["Error"] = "Usuario o contraseña incorrectos";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Alumnos()
        {
            return View();
        }

        public IActionResult Notas()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View();
        }

        public IActionResult Personas()
        {
            return View();
        }

        public IActionResult Usuarios()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}