using Microsoft.AspNetCore.Mvc;

namespace _04_MVC.Views.Home.account
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
