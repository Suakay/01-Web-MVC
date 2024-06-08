using Microsoft.AspNetCore.Mvc;

namespace _09_Core_PssingDataToView.Controllers
{
    public class SiparişController : Controller
    {
        public IActionResult UrunSat()
        {
            return View();
        }
        [HttpPost]  
        public IActionResult UrunSat(IFormCollection koleksiyon)
        {
            TempData["SatılanUrunID"] = Convert.ToInt32(koleksiyon["urunID"]);
            TempData["SatılanUrunAdi"] = koleksiyon["urunAdi"].ToString();
            TempData["SatılanUrunFiyatı"] = koleksiyon["urunFiyatı"].ToString;
            //Formdan almış olduğumuz verileri TempData ile uruncontroller daki stokazalt isimli action metoda aktarmış oluyoruz.
            return View();  
        }
    }
}
