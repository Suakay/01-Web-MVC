using Microsoft.AspNetCore.Mvc;

namespace _09_Core_PssingDataToView.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Tarih=
            DateTime.Now.ToLongDateString();
            ViewBag.Koleksiyon = new string[]
            {
                
                "Bilge","Ayşe","Veli"
            };



            ViewData["Saat"]=
                DateTime.Now.ToLongDateString();
            TempData["Gun"] = DateTime.Now.Day;
            return View();
        }
        public IActionResult Index2()
        {
            TempData["Ay"] = DateTime.Now.Month;
            return RedirectToAction("Index2"); 

            
        } 

       
    }
}
