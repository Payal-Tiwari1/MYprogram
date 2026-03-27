using Microsoft.AspNetCore.Mvc;
using ModelBindingASPCore.Models;
using System.Diagnostics;

namespace ModelBindingASPCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Details(int id, string name)
        {
            return " id is: "+ id + " Name is: " + name;
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
