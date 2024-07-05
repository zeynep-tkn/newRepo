using Microsoft.AspNetCore.Mvc;
using OtelRezervasyonSitesi.Models;
using System.Diagnostics;

namespace OtelRezervasyonSitesi.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
<<<<<<< HEAD
        public IActionResult OtelGenelBakis()
        {
            return View();
        }
        public IActionResult Konaklama()
        {
            return View();
        }




=======
        public IActionResult Restoran()
        {
            return View();
        }
        public IActionResult Hizmetlerimiz()
        {
            return View();
        }
>>>>>>> cb96f964ac8b2ce13737aa1dd07ea83d54c7e778

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
