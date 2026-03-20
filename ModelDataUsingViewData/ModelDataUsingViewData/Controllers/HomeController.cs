using Microsoft.AspNetCore.Mvc;
using ModelDataUsingViewData.Models;
using System.Diagnostics;

namespace ModelDataUsingViewData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Employee employee = new Employee()
            //{
            //    empId = 1,
            //    empName = "Payal Tiwari",
            //    empDesignation = "Manager",
            //    empSalary = 60000
            //};

            var myEmployee = new List<Employee>()
            {
              new Employee { empId = 1, empName = "Payal Tiwari", empDesignation = "Manager", empSalary = 60000 },  
              new Employee { empId = 2, empName = "Rohit Kumar", empDesignation = "Developer", empSalary = 50000 },
              new Employee { empId = 3, empName = "Anjali Singh", empDesignation = "Designer", empSalary = 45000 },
              new Employee { empId = 4, empName = "Vikram Patel", empDesignation = "Tester", empSalary = 40000 },
              new Employee { empId = 5, empName = "Sneha Sharma", empDesignation = "HR", empSalary = 55000 }
            };

            //ViewData["myEmployee"] = myEmployee;
            //ViewBag.myEmployee = myEmployee;
            TempData["myEmployee"] = myEmployee;

            // ViewData["myEmployee"] = employee;
            //ViewBag.myEmployee = employee;
            //TempData["myEmployee"] = employee;
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
