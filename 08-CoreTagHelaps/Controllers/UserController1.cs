using _08_CoreTagHelaps.Models;
using Microsoft.AspNetCore.Mvc;

namespace _08_CoreTagHelaps.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TagHelpers() => View();
        public IActionResult TagHelpers(UserController1 user)
        {
            return RedirectToAction("HtmlHelpers");
        }
        [HttpPost]//HTTP Post isteklerine cevap verecek action metot.(TagHelpers action name ine gelene 
        public IActionResult HtmlHelpers() => View();   

    }
    [HttpPost]
    public IActionResult HtmlHelpers(User user)
    {
        return 
    }
}
