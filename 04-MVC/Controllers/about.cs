using Microsoft.AspNetCore.Mvc;

namespace _04_MVC.Controllers
{
    public class about : Controller
    {
        public IActionResult Index()//ındex actıon methodu view methodun constructrı çağırılır.
            //geri Iaction result tipinde dönüyor.
        {
            return View();
        }
    }
}
