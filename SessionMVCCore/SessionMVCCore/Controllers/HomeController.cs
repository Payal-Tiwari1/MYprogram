using Microsoft.AspNetCore.Mvc;
using SessionMVCCore.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace SessionMVCCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Key", "Payal Tiwari");
            return View();
        }
        public IActionResult About()
        {
            if (HttpContext.Session.GetString("Key") != null)
            {
                ViewBag.Data = HttpContext.Session.GetString("Key").ToString();
            }
            return View();
        }
        public IActionResult Detail()
        {
            if(HttpContext.Session.GetString("Key") != null)
            {
                ViewBag.Data = HttpContext.Session.GetString("Key").ToString();
            }
            return View();
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("Key") != null)
            {
                HttpContext.Session.Remove("Key");
            }
            return View();
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
