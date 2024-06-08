using _05_MVC_AppNortwid.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _05_MVC_AppNortwid.Controllers
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
            NorthwinContext context=
        }
         
        public IActionResult Privacy()
        {
            return View();
            List Category<>
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
