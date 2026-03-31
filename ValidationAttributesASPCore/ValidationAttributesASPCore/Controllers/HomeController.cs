using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValidationAttributesASPCore.Models;

namespace ValidationAttributesASPCore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student std)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear();
            }
            return View();
            //if(ModelState.IsValid)
            //{
            //    return "Name is: " + std.Name;
            //}
            //else
            //{
            //    return "Validation Failed";
            //}
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
