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

        public IActionResult TipoAsignatura()
        {
            return View();
        }

        public IActionResult IngresoCurso()
        {
            return View();
        }

        public IActionResult Menu()
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