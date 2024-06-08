using Microsoft.AspNetCore.Mvc;

namespace _09_Core_PssingDataToView.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult StokAzalt()
        {
            int id = Convert.ToInt32(TempData["id"]);
            string adi = TempData["SatılanUrunAdı"].ToString();
            string fiyat = TempData["SatılanUrunFiyat"].ToString();

            ViewBag.UrunId= id; 
            ViewBag.UrunAdı= adi;
            ViewBag.UrunFiyati= fiyat;  
            return View();
        }
    }
}
