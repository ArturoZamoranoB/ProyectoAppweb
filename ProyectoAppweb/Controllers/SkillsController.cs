using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoAppweb.Models;
using System.Diagnostics;

namespace ProyectoAppweb.Controllers
{
    public class SkillsController : Controller
    {
        private readonly ILogger<SkillsController> _logger;

        public SkillsController(ILogger<SkillsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Skills()
        {
            ViewData["Title"] = "Mis Habilidades";
            ViewData["Message"] = "Aquí puedes encontrar una lista de mis habilidades y destrezas.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
