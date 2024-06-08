using Microsoft.AspNetCore.Mvc;

namespace _04_MVC.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
