using Microsoft.AspNetCore.Mvc;
using PartialViewASPCore.Models;
using System.Diagnostics;

namespace PartialViewASPCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Product()
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 101, ProductName = "Dress", Discription = "This is a Dress", Price = 2500, Image = "~/Images/istockphoto-1440977634-612x612.jpg" },
                new Product() { Id = 201, ProductName = "Pot", Discription = "This is a Pot", Price = 1500, Image = "~/Images/clay-pot-372.jpg" },
                new Product() { Id = 301, ProductName = "Shoe", Discription = "This is a Toy", Price = 3500, Image = "~/Images/jpg.jpg" },
            };
            
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
