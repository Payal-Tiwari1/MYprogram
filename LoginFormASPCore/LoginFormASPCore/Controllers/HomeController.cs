using LoginFormASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace LoginFormASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext context;

        public HomeController(MyDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("userEmail") != null)
            {
                return RedirectToAction("Dashboard");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserTbl1 user)
        {
            var myUser = context.UserTbl1s.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefault();
            if(myUser != null)
            {
                HttpContext.Session.SetString("userEmail", myUser.Email);
                return RedirectToAction("Dashboard");
            }
            else 
            {
                ViewBag.Message = "Login Failed..";
            }
            return View();
        }

        public IActionResult Dashboard()
        {
            // 🔴 Prevent browser caching
            Response.Headers["Cache-Control"] = "no-cache, no-store, must-revalidate";
            Response.Headers["Pragma"] = "no-cache";
            Response.Headers["Expires"] = "0";
            
            
            if (HttpContext.Session.GetString("userEmail")!= null)
            {
                ViewBag.MySession = HttpContext.Session.GetString("userEmail").ToString();
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("userEmail") != null)
            {
                HttpContext.Session.Remove("userEmail");
                return RedirectToAction("Index");
            }
            return View("Login");
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
