using _06_WebApp_Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace _06_WebApp_Product.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            // Product nesnelerini listeye ekleyin
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "Kitap", ucret=300},
                new Product { Id = 2, Name = "Çanta", ucret=2000 },
                new Product { Id = 3, Name = "Tablet", ucret = 15000, }
            };

          
            return View(products);
        }
    }
}
