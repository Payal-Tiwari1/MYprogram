using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewASP.Models;
using System.Diagnostics;

namespace StronglyTypedViewASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Employee obj = new Employee()
            //{
            //    empId = 1,
            //    empName = "Payal Tiwari",
            //    empDesignation = "Software Engineer",
            //    empSalary = 50000
            //};

            var myEmployee = new List<Employee>() 
            {
                new Employee() { empId = 1, empName = "Payal Tiwari", empDesignation = "Software Engineer", empSalary = 50000 },
                new Employee() { empId = 2, empName = "Rahul Sharma", empDesignation = "Senior Software Engineer", empSalary = 70000 },
                new Employee() { empId = 3, empName = "Anjali Verma", empDesignation = "Project Manager", empSalary = 90000 },
                new Employee() { empId = 4, empName = "Vikram Singh", empDesignation = "QA Engineer", empSalary = 45000 },
                new Employee() { empId = 5, empName = "Sneha Patel", empDesignation = "UI/UX Designer", empSalary = 55000 }                                           

            };
            
            return View(myEmployee);
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
