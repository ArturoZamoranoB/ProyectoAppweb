using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoAppweb.Models;
using System.Diagnostics;

namespace ProyectoAppweb.Controllers
{
    public class ContactosController : Controller
    {
        private readonly ILogger<ContactosController> _logger;

        public ContactosController(ILogger<ContactosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Contactos()
        {
            ViewData["Title"] = "Contacto";
            ViewData["Message"] = "Ponte en contacto conmigo utilizando la información a continuación.";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
