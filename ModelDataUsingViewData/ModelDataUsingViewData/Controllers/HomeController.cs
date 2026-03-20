using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;
using System.Diagnostics;

namespace ModelDataUsingViewData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee()
            {
                empId = 1,
                empName = "Payal Tiwari",
                empDesignation = "Manager",
                empSalary = 60000
            };

            // ViewData["myEmployee"] = employee;
            //ViewBag.myEmployee = employee;
            TempData["myEmployee"] = employee;
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
