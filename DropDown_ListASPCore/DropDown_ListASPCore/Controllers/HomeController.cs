using DropDown_ListASPCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace DropDown_ListASPCore.Controllers
{
    public enum Gender
    {
        Male,
        Female,
    }
}

namespace DropDown_ListASPCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<SelectListItem> Gender = new()
            {
                new SelectListItem {Value = "Male", Text = "Male"},
                new SelectListItem {Value = "Female", Text = "Female" }
            };

            ViewBag.Gender = Gender;
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
