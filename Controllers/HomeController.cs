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
            // Tu lógica de inicio de sesión aquí

            // Ejemplo de validación básica (deberías usar autenticación real):
            if (username == "usuario" && password == "contraseña")
            {
                // Usuario y contraseña válidos, redirigir a la vista "Index" del controlador "Home"
                return RedirectToAction("Menu", "Home");
            }
            else
            {
                // Usuario o contraseña incorrectos, mostrar mensaje de error
                TempData["Error"] = "Usuario o contraseña incorrectos";
                return RedirectToAction("Index"); // Redirigir a la página de inicio de sesión
            }
        }

        public IActionResult Menu()
        {

            // Resto del código...
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