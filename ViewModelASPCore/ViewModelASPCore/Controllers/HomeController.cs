using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelASPCore.Models;

namespace ViewModelASPCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1,Name="John",Gender="Male",Standard=10},
                new Student{Id=2,Name="King",Gender="Male",Standard=10},
                new Student{Id=3,Name="Smith",Gender="Male",Standard=10},
                new Student{Id=4,Name="Marry",Gender="Female",Standard=10}
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher{Id=1,Name="Durgesh",Qualification="B.Ed",Salary=50000},
                new Teacher{Id=2,Name="Dishank",Qualification="B.Ed",Salary=50000},
                new Teacher{Id=3,Name="Hetvik",Qualification="B.Ed",Salary=50000},
                new Teacher{Id=4,Name="Viha",Qualification="B.Ed",Salary=50000}
            };

            SchoolViewModel svm = new SchoolViewModel()
            {
                myStudents = students,
                myTeachers = teachers
            };
            return View(svm);
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
