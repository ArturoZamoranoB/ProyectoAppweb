using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoAppweb.Models;
using System.Diagnostics;

namespace ProyectoAppweb.Controllers
{
    public class ProyectosController : Controller
    {
        private readonly ILogger<ProyectosController> _logger;

        public ProyectosController(ILogger<ProyectosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Proyectos()
        {
            ViewData["Title"] = "Mis Proyectos";
            ViewData["Message"] = "Aquí puedes encontrar una lista de mis proyectos realizados.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
